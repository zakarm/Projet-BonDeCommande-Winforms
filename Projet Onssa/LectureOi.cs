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
    public partial class LectureOi : Form
    {
        public LectureOi()
        {
            InitializeComponent();
        }

        private void LectureOi_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Oi.ValueMember = "IdOI";
                cb_Oi.DisplayMember = "NumOI";
                cb_Oi.DataSource = ctx.OISet.ToList();
            }
        }

        private void cb_Oi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from oi in ctx.OISet 
                            join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                            join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                            join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                            join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                            m.InfoFournisseur.IdFournisseur
                            where oi.IdOI == (int)cb_Oi.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                            select new
                            {
                                total = m.Ttc,
                                NumBc = bc.NumBc,
                                NomFr = m.InfoFournisseur.Nom,
                                idoi = oi.IdOI,
                                NumOi = oi.NumOi,
                                DateBc = bc.DateBC,
                                NumCompte = oi.NumCompteDebit,
                                DateOi = oi.DateOI,
                                Code = bc.InfoMorasse.CodeMorasse,
                                Objet = m.InfoConsultation.ObjetConsultation,
                                Exercice = bc.InfoMorasse.Exercice,
                                Compte = m.InfoFournisseur.Compte_bancaire_n,
                                VisaContol = oi.VisaControle,
                                Visacsrs = oi.VisaCsrs,
                                DatePaiement = oi.DatePaiement,
                                VisaSousOrdo = oi.VisaSordonnateur,
                                VisaTresorier = oi.VisaTresorierPayeur,
                                Lrg = bc.InfoMorasse.Ligne.InfoLrg.NumLrg,
                                Par = bc.InfoMorasse.Ligne.InfoLrg.InfoParagraphe.NumPar,
                                Ligne = bc.InfoMorasse.Ligne.CodeLigne,

                            };

                if(query.FirstOrDefault() != null)
                {
                        NumToString cc = new NumToString();
                        CrystalReportOi ce = new CrystalReportOi();
                        ce.SetParameterValue("lrg", query.FirstOrDefault().Lrg.ToString());
                        ce.SetParameterValue("par", query.FirstOrDefault().Par.ToString());
                        ce.SetParameterValue("ligne", query.FirstOrDefault().Ligne.ToString());
                        ce.SetParameterValue("ttc", query.FirstOrDefault().total.ToString());
                        ce.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
                        ce.SetParameterValue("nomfr", query.FirstOrDefault().NomFr.ToString());
                        ce.SetParameterValue("numoi", query.FirstOrDefault().NumOi.ToString());
                        ce.SetParameterValue("numcompte", query.FirstOrDefault().NumCompte.ToString());
                        ce.SetParameterValue("dateoi", query.FirstOrDefault().DateOi.ToString());
                        ce.SetParameterValue("datebc", query.FirstOrDefault().DateBc.ToString());
                        ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                        ce.SetParameterValue("exercice", query.FirstOrDefault().Exercice.ToString());
                        ce.SetParameterValue("compte", query.FirstOrDefault().Compte.ToString());
                        ce.SetParameterValue("lettre", cc.virgule(query.FirstOrDefault().total.ToString()));
                        ce.SetParameterValue("visacontrol", query.FirstOrDefault().VisaContol.ToString());
                        ce.SetParameterValue("visacsrs", query.FirstOrDefault().Visacsrs.ToString());
                        ce.SetParameterValue("datepaiement", query.FirstOrDefault().DatePaiement.ToString());
                        ce.SetParameterValue("visasous", query.FirstOrDefault().VisaSousOrdo.ToString());
                        ce.SetParameterValue("visatr",query.FirstOrDefault().VisaTresorier.ToString());
                        crystalReportViewer1.ReportSource = ce;
                        crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur dans la fiche d'engagement choisie");

                }

            }
        }
    }
}
