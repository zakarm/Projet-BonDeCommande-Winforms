
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Fournisseur = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtarea_Objet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Num = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fournisseurs :";
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
            this.btn_Modifier.Location = new System.Drawing.Point(562, 542);
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
            this.btn_Ajouter.Location = new System.Drawing.Point(326, 542);
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
            this.btn_Supprimer.Location = new System.Drawing.Point(444, 542);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(644, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "VeuIillez Choisir Les Societes à Consulter";
            // 
            // dgv_Fournisseur
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Fournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Fournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Fournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Fournisseur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Fournisseur.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Fournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Fournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Fournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Fournisseur.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Fournisseur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Fournisseur.DoubleBuffered = true;
            this.dgv_Fournisseur.EnableHeadersVisualStyles = false;
            this.dgv_Fournisseur.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.dgv_Fournisseur.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.Location = new System.Drawing.Point(29, 159);
            this.dgv_Fournisseur.Name = "dgv_Fournisseur";
            this.dgv_Fournisseur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Fournisseur.RowHeadersWidth = 5;
            this.dgv_Fournisseur.RowTemplate.Height = 50;
            this.dgv_Fournisseur.Size = new System.Drawing.Size(878, 277);
            this.dgv_Fournisseur.TabIndex = 33;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtarea_Objet);
            this.materialCard1.Controls.Add(this.dgv_Fournisseur);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.cb_Num);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.bunifuMetroTextbox1);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(924, 498);
            this.materialCard1.TabIndex = 156;
            // 
            // txtarea_Objet
            // 
            this.txtarea_Objet.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_Objet.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_Objet.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_Objet.BorderThickness = 1;
            this.txtarea_Objet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtarea_Objet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtarea_Objet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_Objet.isPassword = false;
            this.txtarea_Objet.Location = new System.Drawing.Point(503, 63);
            this.txtarea_Objet.Margin = new System.Windows.Forms.Padding(4);
            this.txtarea_Objet.Name = "txtarea_Objet";
            this.txtarea_Objet.Size = new System.Drawing.Size(375, 44);
            this.txtarea_Objet.TabIndex = 145;
            this.txtarea_Objet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 142;
            this.label6.Text = "Objet de la Consultation";
            // 
            // cb_Num
            // 
            this.cb_Num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Num.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_Num.FormattingEnabled = true;
            this.cb_Num.Location = new System.Drawing.Point(37, 72);
            this.cb_Num.Name = "cb_Num";
            this.cb_Num.Size = new System.Drawing.Size(358, 27);
            this.cb_Num.TabIndex = 144;
            this.cb_Num.SelectedIndexChanged += new System.EventHandler(this.cb_Num_SelectedIndexChanged_1);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(28, 63);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(375, 44);
            this.bunifuMetroTextbox1.TabIndex = 130;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 20);
            this.label8.TabIndex = 141;
            this.label8.Text = "Numéro de la Consultation";
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(970, 614);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Modifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultationForm";
            this.Text = "ConsultationForm";
            this.Load += new System.EventHandler(this.ConsultationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Modifier;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supprimer;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Fournisseur;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtarea_Objet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Num;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label8;
    }
}