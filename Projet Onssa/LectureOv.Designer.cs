
namespace Projet_Onssa
{
    partial class LectureOv
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
            this.cb_Ov = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrystalReportOv1 = new Projet_Onssa.CrystalReportOv();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReportOv1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(984, 614);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cb_Ov
            // 
            this.cb_Ov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Ov.FormattingEnabled = true;
            this.cb_Ov.Location = new System.Drawing.Point(584, 6);
            this.cb_Ov.Name = "cb_Ov";
            this.cb_Ov.Size = new System.Drawing.Size(155, 21);
            this.cb_Ov.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(481, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordre de virement";
            // 
            // LectureOv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Ov);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "LectureOv";
            this.Text = "LectureOv";
            this.Load += new System.EventHandler(this.LectureOv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cb_Ov;
        private System.Windows.Forms.Label label1;
        private CrystalReportOv CrystalReportOv1;
    }
}