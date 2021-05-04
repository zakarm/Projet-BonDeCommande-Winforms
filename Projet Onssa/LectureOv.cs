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
    public partial class LectureOv : Form
    {
      public LectureOv()
        {
            InitializeComponent();
        }

        private void LectureOv_Load(object sender, EventArgs e)
        {

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Ov.ValueMember = "IdOV";
                cb_Ov.DisplayMember = "NumOV";
                cb_Ov.DataSource = ctx.OVSet.ToList();
            }

            
        }

        private void cb_Ov_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from ov in ctx.OVSet
                            join op in ctx.OPSet on ov.InfoOP.IdOP equals op.IdOP
                            join oi in ctx.OISet on op.InfoOI.IdOI equals oi.IdOI
                            join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                            join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                            join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                            join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                            m.InfoFournisseur.IdFournisseur
                            join fr in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals fr.IdFournisseur
                            
                            where ov.IdOV == (int)cb_Ov.SelectedValue && m.InfoConsultation.IdConsultation== pvj.InfoConsultation.IdConsultation
                            select new
                            {
                                ttc = m.Ttc,
                                nom = fr.Nom,
                                compte = fr.Compte_bancaire_n,
                                numop = op.NumOP,
                                sou = ov.SousOrdonnateur,
                                tr = ov.TresorierPayeur,
                                numov = ov.NumOV,
                                banque = fr.Banque,
                            };

                
                CrystalReportOv ce = new CrystalReportOv();
                ce.SetParameterValue("ttc", query.FirstOrDefault().ttc.ToString());
                ce.SetParameterValue("nom", query.FirstOrDefault().nom.ToString());
                ce.SetParameterValue("compte", query.FirstOrDefault().compte.ToString());
                ce.SetParameterValue("numop", query.FirstOrDefault().numop.ToString());
                ce.SetParameterValue("sou", query.FirstOrDefault().sou.ToString());
                ce.SetParameterValue("tr", query.FirstOrDefault().tr.ToString());
                ce.SetParameterValue("numov", query.FirstOrDefault().numov.ToString());
                ce.SetParameterValue("banque", query.FirstOrDefault().banque.ToString());
                crystalReportViewer1.ReportSource = ce;
                crystalReportViewer1.Refresh();
            }



        }
    }
}
