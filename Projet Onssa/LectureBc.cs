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
    public partial class LectureBc : Form
    {
        public LectureBc()
        {
            InitializeComponent();
        }

        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetReportTableAdapters.ModeleDevisSetTableAdapter();
        DataSetReportTableAdapters.PVJFournisseurTableAdapter dapf = new DataSetReportTableAdapters.PVJFournisseurTableAdapter();
        DataSetReportTableAdapters.ModeleDevisProduitTableAdapter dap = new DataSetReportTableAdapters.ModeleDevisProduitTableAdapter();
        DataSetReportTableAdapters.ProduitSetTableAdapter dapr = new DataSetReportTableAdapters.ProduitSetTableAdapter();
        
        private void cb_Bc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from bc in ctx.BCSet join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where bc.IdBC == (int)cb_Bc.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new
                                {
                                    AdresseFour = m.InfoFournisseur.Adresse,
                                    Cnss = m.InfoFournisseur.CNSS_n,
                                    Ifn = m.InfoFournisseur.IF_n,
                                    Patente = m.InfoFournisseur.Patente_n,
                                    NumBc = bc.NumBc,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Code = bc.InfoMorasse.CodeMorasse,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    Exercice = bc.InfoMorasse.Exercice,
                                    Compte = m.InfoFournisseur.Compte_bancaire_n,
                                    Lrg = bc.InfoMorasse.Ligne.InfoLrg.NumLrg,
                                    Par = bc.InfoMorasse.Ligne.InfoLrg.InfoParagraphe.NumPar,
                                    Ligne = bc.InfoMorasse.Ligne.CodeLigne,
                                    NumPvj = pvj.IdPVJ,
                                    NumCon = pvj.InfoConsultation.IdConsultation,
                                    Budget = bc.InfoMorasse.Budget,
                                    Rc = m.InfoFournisseur.RC_n,
                                    Ice = m.InfoFournisseur.ICE,
                                    NumDevis = m.NumDevis,
                                    IdDevis = m.IdModeleDevis,
                                    Tva = m.Tva,
                                    Ttc = m.Ttc,
                                    thc = m.Total,
                                    DateBc = bc.DateBC,

                                };


                    int NumDevis = int.Parse(query.FirstOrDefault().IdDevis.ToString());
                    NumToString cc = new NumToString();
                    dapr.FillByMd(ds.ProduitSet, NumDevis);
                    CrystalReportBC ce = new CrystalReportBC();
                    ce.SetDataSource(ds);
                    ce.SetParameterValue("numdevis", query.FirstOrDefault().NumDevis.ToString());
                    ce.SetParameterValue("ice", query.FirstOrDefault().Ice.ToString());
                    ce.SetParameterValue("rc", query.FirstOrDefault().Rc.ToString());
                    ce.SetParameterValue("budget", query.FirstOrDefault().Budget.ToString());
                    ce.SetParameterValue("if", query.FirstOrDefault().Ifn.ToString());
                    ce.SetParameterValue("cnss", query.FirstOrDefault().Cnss.ToString());
                    ce.SetParameterValue("patente", query.FirstOrDefault().Patente.ToString());
                    ce.SetParameterValue("lrg", query.FirstOrDefault().Lrg.ToString());
                    ce.SetParameterValue("par", query.FirstOrDefault().Par.ToString());
                    ce.SetParameterValue("ligne", query.FirstOrDefault().Ligne.ToString());
                    ce.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
                    ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                    ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                    ce.SetParameterValue("exercice", query.FirstOrDefault().Exercice.ToString());
                    ce.SetParameterValue("compte", query.FirstOrDefault().Compte.ToString());
                    ce.SetParameterValue("adresse", query.FirstOrDefault().AdresseFour.ToString());
                    ce.SetParameterValue("thc", query.FirstOrDefault().thc.ToString());
                    ce.SetParameterValue("tva", query.FirstOrDefault().Tva.ToString());
                    ce.SetParameterValue("ttc", query.FirstOrDefault().Ttc.ToString());
                    ce.SetParameterValue("datebc", query.FirstOrDefault().DateBc.ToString());
                    ce.SetParameterValue("numm", cc.virgule(query.FirstOrDefault().Ttc.ToString()));
                    crystalReportViewer1.ReportSource = ce;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LectureBc_Load(object sender, EventArgs e)
        {
            dapf.Fill(ds.PVJFournisseur);
            dam.Fill(ds.ModeleDevisSet);
            dap.Fill(ds.ModeleDevisProduit);

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Bc.ValueMember = "IdBC";
                cb_Bc.DisplayMember = "NumBC";
                cb_Bc.DataSource = ctx.BCSet.ToList();
            }

        }
    }
}
