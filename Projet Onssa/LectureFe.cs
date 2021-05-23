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
    public partial class LectureFe : Form
    {
        public LectureFe()
        {
            InitializeComponent();
        }

        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetReportTableAdapters.ModeleDevisSetTableAdapter();
        DataSetReportTableAdapters.PVJFournisseurTableAdapter dapf = new DataSetReportTableAdapters.PVJFournisseurTableAdapter();
        DataSetReportTableAdapters.ModeleDevisProduitTableAdapter dap = new DataSetReportTableAdapters.ModeleDevisProduitTableAdapter();
        DataSetReportTableAdapters.ConsultationSetTableAdapter dac = new DataSetReportTableAdapters.ConsultationSetTableAdapter();
        DataSetReportTableAdapters.LettreConsultationSetTableAdapter dl = new DataSetReportTableAdapters.LettreConsultationSetTableAdapter();

        private void LectureFe_Load(object sender, EventArgs e)
        {
            dapf.Fill(ds.PVJFournisseur);
            dap.Fill(ds.ModeleDevisProduit);
            dl.Fill(ds.LettreConsultationSet);



            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Fe.ValueMember = "IdFE";
                cb_Fe.DisplayMember = "NumFE";
                cb_Fe.DataSource = ctx.FESet.ToList();

            }
                

        }

        private void cb_Fe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from fe in ctx.FESet
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where fe.IdFE == (int)cb_Fe.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new
                                {
                                    AdresseFour = m.InfoFournisseur.Adresse,
                                    Cnss = m.InfoFournisseur.CNSS_n,
                                    Ifn = m.InfoFournisseur.IF_n,
                                    Patente = m.InfoFournisseur.Patente_n,
                                    Numfe = fe.NumFe,
                                    NumBc = bc.NumBc,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Code = bc.InfoMorasse.CodeMorasse,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    Exercice = bc.InfoMorasse.Exercice,
                                    Compte = m.InfoFournisseur.Compte_bancaire_n,
                                    Lrg = bc.InfoMorasse.Ligne.InfoLrg.NumLrg,
                                    Par = bc.InfoMorasse.Ligne.InfoLrg.InfoParagraphe.NumPar,
                                    Ligne = bc.InfoMorasse.Ligne.CodeLigne,
                                    Credit = fe.CreditsBudgetaires,
                                    Depense = fe.DepensesEngagees,
                                    Dispo = fe.Disponible,
                                    Enga = fe.EngagementDepensesPropose,
                                    NumPvj = pvj.IdPVJ,
                                    NumCon = pvj.InfoConsultation.IdConsultation,
                                    Rc = m.InfoFournisseur.RC_n,

                                };


                    int NumPvj = int.Parse(query.FirstOrDefault().NumPvj.ToString());
                    int NumCon= int.Parse(query.FirstOrDefault().NumCon.ToString());

                    //var query2 = from m in ctx.ModeleDevisSet
                    //             join con in ctx.ConsultationSet
                    //                on m.InfoConsultation.IdConsultation equals con.IdConsultation
                    //             where con.IdConsultation == i
                    //             select m;
                    dac.FillByCon(ds.ConsultationSet, NumCon);
                    dam.FillBypvj(ds.ModeleDevisSet, NumPvj, NumCon);
                    CrystalReportFe ce = new CrystalReportFe();
                    ce.SetDataSource(ds);
                    ce.SetParameterValue("numfe", query.FirstOrDefault().Numfe.ToString());
                    ce.SetParameterValue("if", query.FirstOrDefault().Ifn.ToString());
                    ce.SetParameterValue("cnss", query.FirstOrDefault().Cnss.ToString());
                    ce.SetParameterValue("enga", query.FirstOrDefault().Enga.ToString());
                    ce.SetParameterValue("patent", query.FirstOrDefault().Patente.ToString());
                    ce.SetParameterValue("dispo", query.FirstOrDefault().Dispo.ToString());
                    ce.SetParameterValue("credit", query.FirstOrDefault().Credit.ToString());
                    ce.SetParameterValue("depense", query.FirstOrDefault().Depense.ToString());
                    ce.SetParameterValue("lrg", query.FirstOrDefault().Lrg.ToString());
                    ce.SetParameterValue("par", query.FirstOrDefault().Par.ToString());
                    ce.SetParameterValue("ligne", query.FirstOrDefault().Ligne.ToString());
                    ce.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
                    ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                    ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                    ce.SetParameterValue("exercice", query.FirstOrDefault().Exercice.ToString());
                    ce.SetParameterValue("compte", query.FirstOrDefault().Compte.ToString());
                    ce.SetParameterValue("adresse", query.FirstOrDefault().AdresseFour.ToString());
                    ce.SetParameterValue("rc", query.FirstOrDefault().Rc.ToString());


                    crystalReportViewer1.ReportSource = ce;
                    crystalReportViewer1.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
