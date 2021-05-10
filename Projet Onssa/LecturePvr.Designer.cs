
namespace Projet_Onssa
{
    partial class LecturePvr
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Pvr = new System.Windows.Forms.ComboBox();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(952, 536);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label1.Location = new System.Drawing.Point(562, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pvr";
            // 
            // cb_Pvr
            // 
            this.cb_Pvr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Pvr.FormattingEnabled = true;
            this.cb_Pvr.Location = new System.Drawing.Point(602, 4);
            this.cb_Pvr.Name = "cb_Pvr";
            this.cb_Pvr.Size = new System.Drawing.Size(155, 21);
            this.cb_Pvr.TabIndex = 12;
            this.cb_Pvr.SelectedIndexChanged += new System.EventHandler(this.cb_Pvr_SelectedIndexChanged);
            // 
            // LecturePvr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Pvr);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "LecturePvr";
            this.Text = "LecturePvr";
            this.Load += new System.EventHandler(this.LecturePvr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Pvr;
    }
}