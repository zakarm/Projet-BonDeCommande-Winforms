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
        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.ProduitSetTableAdapter dap = new DataSetReportTableAdapters.ProduitSetTableAdapter();
        DataSetReportTableAdapters.ModeleDevisSetTableAdapter dam = new DataSetReportTableAdapters.ModeleDevisSetTableAdapter();
        DataSetReportTableAdapters.ModeleDevisProduitTableAdapter damp = new DataSetReportTableAdapters.ModeleDevisProduitTableAdapter();
        DataSetReportTableAdapters.OVSetTableAdapter daov = new DataSetReportTableAdapters.OVSetTableAdapter();
        DataSetReportTableAdapters.OISetTableAdapter daoi = new DataSetReportTableAdapters.OISetTableAdapter();
        DataSetReportTableAdapters.BCSetTableAdapter dabc = new DataSetReportTableAdapters.BCSetTableAdapter();
        DataSetReportTableAdapters.OPSetTableAdapter daop = new DataSetReportTableAdapters.OPSetTableAdapter();
        DataSetReportTableAdapters.FESetTableAdapter dafe = new DataSetReportTableAdapters.FESetTableAdapter();
        DataSetReportTableAdapters.PVJSetTableAdapter dapvj = new DataSetReportTableAdapters.PVJSetTableAdapter();
        DataSetReportTableAdapters.FournisseurSetTableAdapter daf = new DataSetReportTableAdapters.FournisseurSetTableAdapter();
        DataSetReportTableAdapters.ConsultationSetTableAdapter dcon = new DataSetReportTableAdapters.ConsultationSetTableAdapter();
        DataSetReportTableAdapters.PVJFournisseurTableAdapter dapvjf = new DataSetReportTableAdapters.PVJFournisseurTableAdapter();
        public LectureOv()
        {
            InitializeComponent();
        }

        private void LectureOv_Load(object sender, EventArgs e)
        {
            dabc.Fill(ds.BCSet);
            dafe.Fill(ds.FESet);
            dapvj.Fill(ds.PVJSet);
            daf.Fill(ds.FournisseurSet);
            dapvjf.Fill(ds.PVJFournisseur) ;
            dap.Fill(ds.ProduitSet); 
            daov.Fill(ds.OVSet);
            daop.Fill(ds.OPSet);
            daoi.Fill(ds.OISet);
            damp.Fill(ds.ModeleDevisProduit);
           dam.Fill(ds.ModeleDevisSet);
            dcon.Fill(ds.ConsultationSet);

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
                            where ov.IdOV == (int)cb_Ov.SelectedValue && m.InfoConsultation.IdConsultation== pvj.InfoConsultation.IdConsultation
                            select new
                            {
                                ttc = m.Ttc,
                            };

                int i = int.Parse(cb_Ov.SelectedValue.ToString());
                daov.FillByOV(ds.OVSet, i);
                 CrystalReportOv ce = new CrystalReportOv();
                ce.SetDataSource(ds);
                ce.SetParameterValue("ttc", query.FirstOrDefault().ttc.ToString());
                crystalReportViewer1.ReportSource = ce;
                crystalReportViewer1.Refresh();
            }



        }
    }
}
