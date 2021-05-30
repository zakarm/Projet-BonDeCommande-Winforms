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

        DataSetPvj ds = new DataSetPvj();


        DataSetPvjTableAdapters.CommissionSetTableAdapter dac = new DataSetPvjTableAdapters.CommissionSetTableAdapter();
        DataSetPvjTableAdapters.PVJCommissionTableAdapter dacp = new DataSetPvjTableAdapters.PVJCommissionTableAdapter();
        DataSetPvjTableAdapters.FournisseurSetTableAdapter daf = new DataSetPvjTableAdapters.FournisseurSetTableAdapter();
        DataSetPvjTableAdapters.PVJFournisseurTableAdapter dapf = new DataSetPvjTableAdapters.PVJFournisseurTableAdapter();
        DataSetPvjTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetPvjTableAdapters.ModeleDevisSetTableAdapter();
       // DataSetPvjTableAdapters.FournisseurReponduSetTableAdapter dafr = new DataSetPvjTableAdapters.FournisseurReponduSetTableAdapter();
        DataSetPvjTableAdapters.ConsultationFournisseurTableAdapter daconf = new DataSetPvjTableAdapters.ConsultationFournisseurTableAdapter();
        DataSetPvjTableAdapters.ConsultationSetTableAdapter dacon = new DataSetPvjTableAdapters.ConsultationSetTableAdapter();
        DataSetPvjTableAdapters.PVJSetTableAdapter dapvj = new DataSetPvjTableAdapters.PVJSetTableAdapter();

        private void LecturePvj_Load(object sender, EventArgs e)
        {

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
                    
                    if(query.FirstOrDefault().NumDevis!=null)
                    { 
                        int IdPvj = int.Parse(query.FirstOrDefault().IdPvj.ToString());


                        daf.Fill(ds.FournisseurSet);
                        dac.Fill(ds.CommissionSet);
                        dam.Fill(ds.ModeleDevisSet);
                        dapvj.Fill(ds.PVJSet);
                       // dafr.Fill(ds.FournisseurReponduSet);
                        dacp.Fill(ds.PVJCommission);
                        dapf.Fill(ds.PVJFournisseur);
                        daconf.Fill(ds.ConsultationFournisseur);
                        dacon.Fill(ds.ConsultationSet);

                        //int IdCon = int.Parse(query.FirstOrDefault().IdCon.ToString());
                        //daf.FillByConsultation(ds.FournisseurSet, IdCon);

                        dapvj.FillByPvj(ds.PVJSet,IdPvj);
                      //dafr.FillByPvj(ds.FournisseurReponduSet, IdPvj);

                        //int IdDevis = int.Parse(query.FirstOrDefault().IdDevis.ToString());
                        //dam.FillByConsultation(ds.ModeleDevisSet, IdCon);

                        //dac.FillByPvj(ds.CommissionSet, IdPvj);





                        DateTime d = query.FirstOrDefault().DatePvj;
                        NumToString num = new NumToString();
                        DateToString dt = new DateToString();
                        string s = "L'an "+ num.Ninetotwelvedigit(d.Year.ToString())+" le "+num.Ninetotwelvedigit(d.Day.ToString()) +" du mois de "+ dt.DateMounth(d.Month);
                        CrystalReportPvj ce = new CrystalReportPvj();
                        ce.SetDataSource(ds);
                        ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                        ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                        ce.SetParameterValue("thc", query.FirstOrDefault().thc.ToString());
                        ce.SetParameterValue("tva", query.FirstOrDefault().Tva.ToString());
                        ce.SetParameterValue("ttc", query.FirstOrDefault().Ttc.ToString());
                        ce.SetParameterValue("datepvj", query.FirstOrDefault().DatePvj.ToString());
                        ce.SetParameterValue("numcon", query.FirstOrDefault().NumCon.ToString());
                        ce.SetParameterValue("date", s);
                        ce.SetParameterValue("numm", cc.virgule(query.FirstOrDefault().Ttc.ToString()));
                        crystalReportViewer1.ReportSource = ce;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("le fournisseur choisie n'a pas un modele de devis");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
