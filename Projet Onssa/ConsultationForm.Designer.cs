
namespace Projet_Onssa
{
    partial class ConsultationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarea_Objet = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_Num = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dgv_Fournisseur = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(441, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fournisseurs :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Objet de la Consultation :";
            // 
            // txtarea_Objet
            // 
            this.txtarea_Objet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtarea_Objet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtarea_Objet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtarea_Objet.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtarea_Objet.Location = new System.Drawing.Point(43, 220);
            this.txtarea_Objet.Name = "txtarea_Objet";
            this.txtarea_Objet.Size = new System.Drawing.Size(358, 159);
            this.txtarea_Objet.TabIndex = 21;
            this.txtarea_Objet.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Numéro de la Consultation :";
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modifier.BorderRadius = 7;
            this.btn_Modifier.ButtonText = "Modifier";
            this.btn_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modifier.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Modifier.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Modifier.Iconimage = null;
            this.btn_Modifier.Iconimage_right = null;
            this.btn_Modifier.Iconimage_right_Selected = null;
            this.btn_Modifier.Iconimage_Selected = null;
            this.btn_Modifier.IconMarginLeft = 0;
            this.btn_Modifier.IconMarginRight = 0;
            this.btn_Modifier.IconRightVisible = true;
            this.btn_Modifier.IconRightZoom = 0D;
            this.btn_Modifier.IconVisible = true;
            this.btn_Modifier.IconZoom = 90D;
            this.btn_Modifier.IsTab = false;
            this.btn_Modifier.Location = new System.Drawing.Point(553, 534);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.selected = false;
            this.btn_Modifier.Size = new System.Drawing.Size(112, 48);
            this.btn_Modifier.TabIndex = 24;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modifier.Textcolor = System.Drawing.Color.White;
            this.btn_Modifier.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ajouter.BorderRadius = 7;
            this.btn_Ajouter.ButtonText = "Ajouter";
            this.btn_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ajouter.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Ajouter.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.Iconimage = null;
            this.btn_Ajouter.Iconimage_right = null;
            this.btn_Ajouter.Iconimage_right_Selected = null;
            this.btn_Ajouter.Iconimage_Selected = null;
            this.btn_Ajouter.IconMarginLeft = 0;
            this.btn_Ajouter.IconMarginRight = 0;
            this.btn_Ajouter.IconRightVisible = true;
            this.btn_Ajouter.IconRightZoom = 0D;
            this.btn_Ajouter.IconVisible = true;
            this.btn_Ajouter.IconZoom = 90D;
            this.btn_Ajouter.IsTab = false;
            this.btn_Ajouter.Location = new System.Drawing.Point(317, 534);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.selected = false;
            this.btn_Ajouter.Size = new System.Drawing.Size(112, 48);
            this.btn_Ajouter.TabIndex = 25;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ajouter.Textcolor = System.Drawing.Color.White;
            this.btn_Ajouter.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Supprimer.BorderRadius = 7;
            this.btn_Supprimer.ButtonText = "Supprimer";
            this.btn_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.Iconimage = null;
            this.btn_Supprimer.Iconimage_right = null;
            this.btn_Supprimer.Iconimage_right_Selected = null;
            this.btn_Supprimer.Iconimage_Selected = null;
            this.btn_Supprimer.IconMarginLeft = 0;
            this.btn_Supprimer.IconMarginRight = 0;
            this.btn_Supprimer.IconRightVisible = true;
            this.btn_Supprimer.IconRightZoom = 0D;
            this.btn_Supprimer.IconVisible = true;
            this.btn_Supprimer.IconZoom = 90D;
            this.btn_Supprimer.IsTab = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(435, 534);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.selected = false;
            this.btn_Supprimer.Size = new System.Drawing.Size(112, 48);
            this.btn_Supprimer.TabIndex = 26;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_Supprimer.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // cb_Num
            // 
            this.cb_Num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Num.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Num.FormattingEnabled = true;
            this.cb_Num.ItemHeight = 19;
            this.cb_Num.Location = new System.Drawing.Point(43, 128);
            this.cb_Num.Name = "cb_Num";
            this.cb_Num.Size = new System.Drawing.Size(360, 27);
            this.cb_Num.TabIndex = 30;
            this.cb_Num.SelectedIndexChanged += new System.EventHandler(this.cb_Num_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(615, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "VeuIillez Choisir Les Societes à Consulter";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 50;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuCards2.Controls.Add(this.dgv_Fournisseur);
            this.bunifuCards2.Controls.Add(this.cb_Num);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.txtarea_Objet);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.label4);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(38, 33);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(905, 471);
            this.bunifuCards2.TabIndex = 150;
            // 
            // dgv_Fournisseur
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Fournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Fournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Fournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Fournisseur.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Fournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Fournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Fournisseur.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Fournisseur.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Fournisseur.DoubleBuffered = true;
            this.dgv_Fournisseur.EnableHeadersVisualStyles = false;
            this.dgv_Fournisseur.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dgv_Fournisseur.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.Location = new System.Drawing.Point(446, 128);
            this.dgv_Fournisseur.Name = "dgv_Fournisseur";
            this.dgv_Fournisseur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Fournisseur.RowHeadersWidth = 5;
            this.dgv_Fournisseur.Size = new System.Drawing.Size(432, 251);
            this.dgv_Fournisseur.TabIndex = 33;
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(970, 614);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Modifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultationForm";
            this.Text = "ConsultationForm";
            this.Load += new System.EventHandler(this.ConsultationForm_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtarea_Objet;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Modifier;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supprimer;
        private System.Windows.Forms.ComboBox cb_Num;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Fournisseur;
    }
}