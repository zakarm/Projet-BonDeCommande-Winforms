
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(984, 614);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cb_Consultation
            // 
            this.cb_Consultation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Consultation.FormattingEnabled = true;
            this.cb_Consultation.Location = new System.Drawing.Point(474, 16);
            this.cb_Consultation.Name = "cb_Consultation";
            this.cb_Consultation.Size = new System.Drawing.Size(155, 21);
            this.cb_Consultation.TabIndex = 1;
            this.cb_Consultation.SelectedIndexChanged += new System.EventHandler(this.cb_Consultation_SelectedIndexChanged);
            // 
            // cb_Fournisseur
            // 
            this.cb_Fournisseur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Fournisseur.FormattingEnabled = true;
            this.cb_Fournisseur.Location = new System.Drawing.Point(635, 16);
            this.cb_Fournisseur.Name = "cb_Fournisseur";
            this.cb_Fournisseur.Size = new System.Drawing.Size(155, 21);
            this.cb_Fournisseur.TabIndex = 2;
            this.cb_Fournisseur.SelectedIndexChanged += new System.EventHandler(this.cb_Fournisseur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(472, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultation";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(632, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fournniseur";
            // 
            // LectureConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Fournisseur);
            this.Controls.Add(this.cb_Consultation);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "LectureConsultation";
            this.Text = "Lecture Pvj";
            this.Load += new System.EventHandler(this.LectureConsultation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cb_Consultation;
        private System.Windows.Forms.ComboBox cb_Fournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}