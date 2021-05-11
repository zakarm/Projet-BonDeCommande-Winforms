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
    public partial class LecturePvr : Form
    {
        public LecturePvr()
        {
            InitializeComponent();
        }
        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.CommissionPVRTableAdapter dacp = new DataSetReportTableAdapters.CommissionPVRTableAdapter();
        DataSetReportTableAdapters.CommissionSetTableAdapter dac = new DataSetReportTableAdapters.CommissionSetTableAdapter();
        DataSetReportTableAdapters.PVRSetTableAdapter dapvr = new DataSetReportTableAdapters.PVRSetTableAdapter();
        private void LecturePvr_Load(object sender, EventArgs e)
        {
            dacp.Fill(ds.CommissionPVR);
            dapvr.Fill(ds.PVRSet);


            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Pvr.ValueMember = "IdPVR";
                cb_Pvr.DisplayMember = "NumPvr";
                cb_Pvr.DataSource = ctx.PVRSet.ToList();
            }

        }

        private void cb_Pvr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from pvr in ctx.PVRSet
                                join oi in ctx.OISet on pvr.InfoOI.IdOI equals oi.IdOI
                                join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC 
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where pvr.IdPVR == (int)cb_Pvr.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new
                                {
                                    NumBc = bc.NumBc,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Code = bc.InfoMorasse.CodeMorasse,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    Datebc = bc.DateBC,
                                    NumPvr = pvr.IdPVR,
                                };
                    if (query.FirstOrDefault() != null)
                    {
                        dac.FillByPvr(ds.CommissionSet,int.Parse(query.FirstOrDefault().NumPvr.ToString()));
                    CrystalReportPvr ce = new CrystalReportPvr();
                    ce.SetDataSource(ds);
                    ce.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
                    ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                    ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                    ce.SetParameterValue("datebc", query.FirstOrDefault().Datebc.ToString());
                    crystalReportViewer1.ReportSource = ce;
                    crystalReportViewer1.Refresh();

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
