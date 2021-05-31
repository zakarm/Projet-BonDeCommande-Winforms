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
    public partial class LectureMd : Form
    {
        public LectureMd()
        {
            InitializeComponent();
        }
        DataSetReport ds = new DataSetReport();
       

        DataSetReportTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetReportTableAdapters.ModeleDevisSetTableAdapter();
        DataSetReportTableAdapters.PVJFournisseurTableAdapter dapf = new DataSetReportTableAdapters.PVJFournisseurTableAdapter();
        DataSetReportTableAdapters.ModeleDevisProduitTableAdapter dap = new DataSetReportTableAdapters.ModeleDevisProduitTableAdapter();
        DataSetReportTableAdapters.ProduitSetTableAdapter dapr = new DataSetReportTableAdapters.ProduitSetTableAdapter();

        private void LectureMd_Load(object sender, EventArgs e)
        {
            dapf.Fill(ds.PVJFournisseur);
            dam.Fill(ds.ModeleDevisSet);
            dap.Fill(ds.ModeleDevisProduit);

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Md.ValueMember = "IdModeleDevis";
                cb_Md.DisplayMember = "NumDevis";
                cb_Md.DataSource = ctx.ModeleDevisSet.ToList();
            }
        }

        private void cb_Md_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from m in ctx.ModeleDevisSet
                                where m.IdModeleDevis == (int)cb_Md.SelectedValue
                                select new
                                {
                                    AdresseFour = m.InfoFournisseur.Adresse,
                                    Cnss = m.InfoFournisseur.CNSS_n,
                                    Ifn = m.InfoFournisseur.IF_n,
                                    Patente = m.InfoFournisseur.Patente_n,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    Compte = m.InfoFournisseur.Compte_bancaire_n,
                                    Rc = m.InfoFournisseur.RC_n,
                                    Ice = m.InfoFournisseur.ICE,
                                    NumDevis = m.NumDevis,
                                    IdDevis = m.IdModeleDevis,
                                    Tva = m.Tva,
                                    Ttc = m.Ttc,
                                    thc = m.Total,
                                    DateDevis = m.Date,
                                    NumCon = m.InfoConsultation.NumConsultation,

                                };


                    int NumDevis = int.Parse(query.FirstOrDefault().IdDevis.ToString());
                    NumToString cc = new NumToString();
                    dapr.FillByMd(ds.ProduitSet, NumDevis);
                    CrystalReportMd ce = new CrystalReportMd();
                    ce.SetDataSource(ds);
                    ce.SetParameterValue("numdevis", query.FirstOrDefault().NumDevis.ToString());
                    //ce.SetParameterValue("ice", query.FirstOrDefault().Ice.ToString());
                    ce.SetParameterValue("rc", query.FirstOrDefault().Rc.ToString());
                    ce.SetParameterValue("if", query.FirstOrDefault().Ifn.ToString());
                    ce.SetParameterValue("cnss", query.FirstOrDefault().Cnss.ToString());
                    ce.SetParameterValue("patente", query.FirstOrDefault().Patente.ToString());
                    ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                    ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                    ce.SetParameterValue("compte", query.FirstOrDefault().Compte.ToString());
                    ce.SetParameterValue("adresse", query.FirstOrDefault().AdresseFour.ToString());
                    ce.SetParameterValue("thc", query.FirstOrDefault().thc.ToString());
                    ce.SetParameterValue("tva", query.FirstOrDefault().Tva.ToString());
                    ce.SetParameterValue("ttc", query.FirstOrDefault().Ttc.ToString());
                    ce.SetParameterValue("datedevis",query.FirstOrDefault().DateDevis.ToString());
                    ce.SetParameterValue("numcon", query.FirstOrDefault().NumCon.ToString());
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
