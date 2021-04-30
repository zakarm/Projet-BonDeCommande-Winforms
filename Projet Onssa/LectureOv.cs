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

            cb_Ov.DisplayMember = "NuMM";
            cb_Ov.ValueMember = "IdOv";

            CrystalReportOv ce = new CrystalReportOv();

            ce.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ce;
            crystalReportViewer1.Refresh();
        }
    }
}
