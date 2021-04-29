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
    public partial class LectureConsultation : Form
    {
        public LectureConsultation()
        {
            InitializeComponent();
        }

        DataSetReport ds = new DataSetReport();
        DataSetReportTableAdapters.ConsultationSetTableAdapter dac = new DataSetReportTableAdapters.ConsultationSetTableAdapter();
        DataSetReportTableAdapters.ConsultationFournisseurTableAdapter dacf = new DataSetReportTableAdapters.ConsultationFournisseurTableAdapter();
        
        DataSetReportTableAdapters.FournisseurSetTableAdapter daf = new DataSetReportTableAdapters.FournisseurSetTableAdapter();
        

        private void cb_Consultation_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {


                daf.Fill(ds.FournisseurSet);
                var query = from f in ds.FournisseurSet
                            join c in ds.ConsultationFournisseur
                            on f.IdFournisseur equals c.ListFournisseur_IdFournisseur
                            where c.ListConsultation_IdConsultation == (int)cb_Consultation.SelectedValue
                            select new
                            {
                                Nom = f.Nom,
                                Num = f.IdFournisseur,
                            };
                cb_Fournisseur.DisplayMember = "Nom";
                cb_Fournisseur.ValueMember = "Num";
                cb_Fournisseur.DataSource = query.ToList();
                           
            }
        }

         private void LectureConsultation_Load(object sender, EventArgs e)
        {
            dacf.Fill(ds.ConsultationFournisseur);
            dac.Fill(ds.ConsultationSet);

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Consultation.DisplayMember = "Numconsultation";
                cb_Consultation.ValueMember = "idconsultation";
                cb_Consultation.DataSource= ctx.ConsultationSet.ToList();

            }

        }

        private void cb_Fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = int.Parse(cb_Fournisseur.SelectedValue.ToString()); 
            daf.FillByFournniseur(ds.FournisseurSet,i);

            CrystalReportConsultation ce = new CrystalReportConsultation();

            ce.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ce;
            crystalReportViewer1.Refresh();
        }
    }
}
