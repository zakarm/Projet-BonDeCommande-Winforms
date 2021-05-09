using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Onssa
{
    public partial class LecturePvj : Form
    {
        public LecturePvj()
        {
            InitializeComponent();
        }

        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.CommissionSetTableAdapter dac = new DataSetReportTableAdapters.CommissionSetTableAdapter();
        DataSetReportTableAdapters.PVJCommissionTableAdapter dacp = new DataSetReportTableAdapters.PVJCommissionTableAdapter();
        DataSetReportTableAdapters.FournisseurSetTableAdapter daf = new DataSetReportTableAdapters.FournisseurSetTableAdapter();
        DataSetReportTableAdapters.PVJFournisseurTableAdapter dapf = new DataSetReportTableAdapters.PVJFournisseurTableAdapter();
        DataSetReportTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetReportTableAdapters.ModeleDevisSetTableAdapter();
        DataSetReportTableAdapters.FournisseurReponduSetTableAdapter dafr = new DataSetReportTableAdapters.FournisseurReponduSetTableAdapter();
        DataSetReportTableAdapters.ConsultationFournisseurTableAdapter daconf = new DataSetReportTableAdapters.ConsultationFournisseurTableAdapter();
        DataSetReportTableAdapters.ConsultationSetTableAdapter dacon = new DataSetReportTableAdapters.ConsultationSetTableAdapter();
        private void LecturePvj_Load(object sender, EventArgs e)
        {
            dacp.Fill(ds.PVJCommission);
            dapf.Fill(ds.PVJFournisseur);
            daconf.Fill(ds.ConsultationFournisseur);
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Pvj.ValueMember = "IdPVJ";
                cb_Pvj.DisplayMember = "NumPvj";
                cb_Pvj.DataSource = ctx.PVJSet.ToList();
            }
        }

        private void cb_Pvj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from pvj in ctx.PVJSet
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where pvj.IdPVJ == (int)cb_Pvj.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new
                                {
                                    IdCon = pvj.InfoConsultation.IdConsultation,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    IdPvj = pvj.IdPVJ,
                                    NumCon = pvj.InfoConsultation.IdConsultation,
                                    NumDevis = m.NumDevis,
                                    IdDevis = m.IdModeleDevis,
                                    Tva = m.Tva,
                                    Ttc = m.Ttc,
                                    thc = m.Total,
                                    DatePvj = pvj.DatePvj,

                                };
                    
                    NumToString cc = new NumToString();
                    

                    int IdCon = int.Parse(query.FirstOrDefault().IdCon.ToString());
                    daf.FillByConsultation(ds.FournisseurSet, IdCon);

                    int IdPvj = int.Parse(query.FirstOrDefault().IdPvj.ToString());
                    dafr.FillByPvj(ds.FournisseurReponduSet, IdPvj);

                    int IdDevis= int.Parse(query.FirstOrDefault().IdDevis.ToString());
                    dam.FillByConsultation(ds.ModeleDevisSet, IdDevis);

                    dac.FillByPvj(ds.CommissionSet, IdPvj);

                    CrystalReportPvj ce = new CrystalReportPvj();
                    ce.SetDataSource(ds);
                    ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                    ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                    ce.SetParameterValue("thc", query.FirstOrDefault().thc.ToString());
                    ce.SetParameterValue("tva", query.FirstOrDefault().Tva.ToString());
                    ce.SetParameterValue("ttc", query.FirstOrDefault().Ttc.ToString());
                    ce.SetParameterValue("datepvj", query.FirstOrDefault().DatePvj.ToString());
                    ce.SetParameterValue("numm",cc.virgule( query.FirstOrDefault().Ttc.ToString()));
                    crystalReportViewer1.ReportSource = ce;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
