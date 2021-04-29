
namespace Projet_Onssa
{
    partial class LectureConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cb_Consultation = new System.Windows.Forms.ComboBox();
            this.cb_Fournisseur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(954, 575);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cb_Consultation
            // 
            this.cb_Consultation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Consultation.FormattingEnabled = true;
            this.cb_Consultation.Location = new System.Drawing.Point(475, 5);
            this.cb_Consultation.Name = "cb_Consultation";
            this.cb_Consultation.Size = new System.Drawing.Size(155, 21);
            this.cb_Consultation.TabIndex = 1;
            this.cb_Consultation.SelectedIndexChanged += new System.EventHandler(this.cb_Consultation_SelectedIndexChanged);
            // 
            // cb_Fournisseur
            // 
            this.cb_Fournisseur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Fournisseur.FormattingEnabled = true;
            this.cb_Fournisseur.Location = new System.Drawing.Point(636, 5);
            this.cb_Fournisseur.Name = "cb_Fournisseur";
            this.cb_Fournisseur.Size = new System.Drawing.Size(155, 21);
            this.cb_Fournisseur.TabIndex = 2;
            this.cb_Fournisseur.SelectedIndexChanged += new System.EventHandler(this.cb_Fournisseur_SelectedIndexChanged);
            // 
            // LectureConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.cb_Fournisseur);
            this.Controls.Add(this.cb_Consultation);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "LectureConsultation";
            this.Text = "Lecture Pvj";
            this.Load += new System.EventHandler(this.LectureConsultation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cb_Consultation;
        private System.Windows.Forms.ComboBox cb_Fournisseur;
    }
}