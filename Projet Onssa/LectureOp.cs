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
        DataSetReport ds = new DataSetReport();

        DataSetReportTableAdapters.MorasseSetTableAdapter damor = new DataSetReportTableAdapters.MorasseSetTableAdapter();
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
        DataSetReportTableAdapters.PVRSetTableAdapter dapvr = new DataSetReportTableAdapters.PVRSetTableAdapter();
        DataSetReportTableAdapters.PVJCommissionTableAdapter dapvjcom = new DataSetReportTableAdapters.PVJCommissionTableAdapter();
        DataSetReportTableAdapters.ConsultationFournisseurTableAdapter daconfour = new DataSetReportTableAdapters.ConsultationFournisseurTableAdapter();
        
        DataSetReportTableAdapters.CommissionSetTableAdapter dacom = new DataSetReportTableAdapters.CommissionSetTableAdapter();
        private void LectureOp_Load(object sender, EventArgs e)
        {
            daconfour.Fill(ds.ConsultationFournisseur);
            damor.Fill(ds.MorasseSet);
            dapvjcom.Fill(ds.PVJCommission);
            dacom.Fill(ds.CommissionSet);
            dapvr.Fill(ds.PVRSet);
            dabc.Fill(ds.BCSet);
            dafe.Fill(ds.FESet);
            dapvj.Fill(ds.PVJSet);
            daf.Fill(ds.FournisseurSet);
            dapvjf.Fill(ds.PVJFournisseur);
            dap.Fill(ds.ProduitSet);
            daov.Fill(ds.OVSet);
            daop.Fill(ds.OPSet);
            daoi.Fill(ds.OISet);
            damp.Fill(ds.ModeleDevisProduit);
            dam.Fill(ds.ModeleDevisSet);
            dcon.Fill(ds.ConsultationSet);

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Op.ValueMember = "IdOP";
                cb_Op.DisplayMember = "NumOP";
                cb_Op.DataSource = ctx.OPSet.ToList();
            }
        }

        private void cb_Op_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from op in ds.OPSet
                        join oi in ds.OISet on op.InfoOI_IdOI equals oi.IdOI
                        join fe in ds.FESet on oi.InfoFE_IdFE equals fe.IdFE
                        join bc in ds.BCSet on fe.InfoBC_IdBC equals bc.IdBC
                        join pvj in ds.PVJSet on bc.InfoPVJ_IdPVJ equals pvj.IdPVJ
                        join m in ds.ModeleDevisSet on pvj.InfoFournisseur_IdFournisseur equals
                        m.InfoFournisseur_IdFournisseur
                        join fr in ds.FournisseurSet on m.InfoFournisseur_IdFournisseur equals fr.IdFournisseur
                        where op.IdOP == (int)cb_Op.SelectedValue && m.InfoConsultation_IdConsultation == pvj.InfoConsultation_IdConsultation
                        select new
                        {
                            total = m.Ttc,
                            NumBc = bc.NumBc,
                            NomFr = fr.Nom,
                            DateBc = bc.DateBC,


                        };

            
            int i = int.Parse(cb_Op.SelectedValue.ToString());
            daop.FillByOp(ds.OPSet, i);


            CrystalReportOp1.SetDataSource(ds);
            CrystalReportOp1.SetParameterValue("ttc", query.FirstOrDefault().total.ToString());
            CrystalReportOp1.SetParameterValue("numbc", query.FirstOrDefault().NumBc.ToString());
            CrystalReportOp1.SetParameterValue("nomfr", query.FirstOrDefault().NomFr.ToString());
            CrystalReportOp1.SetParameterValue("datebc", query.FirstOrDefault().DateBc.ToString());
            CrystalReportOp1.SetParameterValue("datebc", query.FirstOrDefault().DateBc.ToString());
            crystalReportViewer1.ReportSource = CrystalReportOp1;
            crystalReportViewer1.Refresh();
        }
    }
}
