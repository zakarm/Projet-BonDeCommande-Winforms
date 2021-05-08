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
    public partial class LectureOp : Form
    {
        public LectureOp()
        {
            InitializeComponent();
        }
        
        private void LectureOp_Load(object sender, EventArgs e)
        {
            
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Op.ValueMember = "IdOP";
                cb_Op.DisplayMember = "NumOP";
                cb_Op.DataSource = ctx.OPSet.ToList();
            }
        }

        private void cb_Op_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from op in ctx.OPSet
                            join oi in ctx.OISet on op.InfoOI.IdOI equals oi.IdOI
                            join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                            join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                            join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                            join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                            m.InfoFournisseur.IdFournisseur
                            join fr in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals fr.IdFournisseur
                           // join pvr in ctx.PVRSet on oi.IdOI equals pvr.IdPVR
                            where op.IdOP == (int)cb_Op.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                            select new
                            {
                                total = m.Ttc,
                                NumBc = bc.NumBc,
                                NomFr = fr.Nom,
                                idoi = oi.IdOI,
                                NumOi = oi.NumOi,
                                DateBc = bc.DateBC,
                                NumCompte = oi.NumCompteDebit,
                                DateOi = oi.DateOI,
                                NumOp = op.NumOP,
                                Code = bc.InfoMorasse.CodeMorasse,
                                DateOp = op.DateOP,
                                Objet = m.InfoConsultation.ObjetConsultation,
                                Exercice = bc.InfoMorasse.Exercice,
                                Compte = fr.Compte_bancaire_n,
                                //DatePvr = pvr.DatePVR,
                                VisaContol = oi.VisaControle,
                                Visacsrs = oi.VisaCsrs,
                                DatePaiement = oi.DatePaiement,
                                VisaSousOrdo = oi.VisaSordonnateur,
                                VisaTresorier = oi.VisaTresorierPayeur,

                            };

                NumToString cc = new NumToString();
               

                CrystalReportOp ce = new CrystalReportOp();

                ce.SetParameterValue("ttc", query.FirstOrDefault().total.ToString());
                ce.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
                ce.SetParameterValue("nomfr", query.FirstOrDefault().NomFr.ToString());
                ce.SetParameterValue("numoi", query.FirstOrDefault().NumOi.ToString());
                ce.SetParameterValue("numcompte", query.FirstOrDefault().NumCompte.ToString());
                ce.SetParameterValue("dateoi", query.FirstOrDefault().DateOi.ToString());
                ce.SetParameterValue("numop", query.FirstOrDefault().NumOp.ToString());
                ce.SetParameterValue("code", query.FirstOrDefault().Code.ToString());
                ce.SetParameterValue("dateop", query.FirstOrDefault().DateOp.ToString());
                ce.SetParameterValue("datebc", query.FirstOrDefault().DateBc.ToString());
                ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                ce.SetParameterValue("exercice", query.FirstOrDefault().Exercice.ToString());
                ce.SetParameterValue("compte", query.FirstOrDefault().Compte.ToString());
               // ce.SetParameterValue("datepvr", query.FirstOrDefault().DatePvr.ToString());
                ce.SetParameterValue("lettre", cc.virgule(query.FirstOrDefault().total.ToString()));
                ce.SetParameterValue("visacontrol", query.FirstOrDefault().VisaContol.ToString());
                ce.SetParameterValue("visacsrs", query.FirstOrDefault().Visacsrs.ToString());
                ce.SetParameterValue("datepaiement", query.FirstOrDefault().DatePaiement.ToString());
                ce.SetParameterValue("visasous", query.FirstOrDefault().VisaSousOrdo.ToString());
                ce.SetParameterValue("visatr", query.FirstOrDefault().VisaTresorier.ToString());
                crystalReportViewer1.ReportSource = ce;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
