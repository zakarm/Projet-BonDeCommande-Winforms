﻿
namespace Projet_Onssa
{
    partial class PvjForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Fournisseur = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgv_Commission = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.card = new MaterialSkin.Controls.MaterialCard();
            this.date_Pvj = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cb_NumC = new System.Windows.Forms.ComboBox();
            this.txtarea_DateString = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Adresse = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cb_NumPvj = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cb_fchoisie = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).BeginInit();
            this.card.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_Supprimer.Location = new System.Drawing.Point(443, 490);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.selected = false;
            this.btn_Supprimer.Size = new System.Drawing.Size(112, 48);
            this.btn_Supprimer.TabIndex = 40;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_Supprimer.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
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
            this.btn_Ajouter.Location = new System.Drawing.Point(325, 490);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.selected = false;
            this.btn_Ajouter.Size = new System.Drawing.Size(112, 48);
            this.btn_Ajouter.TabIndex = 39;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ajouter.Textcolor = System.Drawing.Color.White;
            this.btn_Ajouter.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
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
            this.btn_Modifier.Location = new System.Drawing.Point(561, 490);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.selected = false;
            this.btn_Modifier.Size = new System.Drawing.Size(112, 48);
            this.btn_Modifier.TabIndex = 38;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modifier.Textcolor = System.Drawing.Color.White;
            this.btn_Modifier.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fournisseurs Repondu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Commissions ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Fournisseur Choisie";
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
            this.dgv_Fournisseur.Location = new System.Drawing.Point(18, 206);
            this.dgv_Fournisseur.Name = "dgv_Fournisseur";
            this.dgv_Fournisseur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Fournisseur.RowHeadersWidth = 5;
            this.dgv_Fournisseur.Size = new System.Drawing.Size(422, 146);
            this.dgv_Fournisseur.TabIndex = 170;
            // 
            // dgv_Commission
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Commission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Commission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Commission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Commission.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Commission.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Commission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Commission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Commission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Commission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Commission.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Commission.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Commission.DoubleBuffered = true;
            this.dgv_Commission.EnableHeadersVisualStyles = false;
            this.dgv_Commission.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.dgv_Commission.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Commission.Location = new System.Drawing.Point(18, 41);
            this.dgv_Commission.Name = "dgv_Commission";
            this.dgv_Commission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Commission.RowHeadersWidth = 5;
            this.dgv_Commission.Size = new System.Drawing.Size(422, 132);
            this.dgv_Commission.TabIndex = 169;
            // 
            // card
            // 
            this.card.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card.Controls.Add(this.date_Pvj);
            this.card.Controls.Add(this.bunifuMetroTextbox3);
            this.card.Controls.Add(this.cb_NumC);
            this.card.Controls.Add(this.txtarea_DateString);
            this.card.Controls.Add(this.txt_Adresse);
            this.card.Controls.Add(this.cb_NumPvj);
            this.card.Controls.Add(this.bunifuMetroTextbox1);
            this.card.Controls.Add(this.label5);
            this.card.Controls.Add(this.label9);
            this.card.Controls.Add(this.label10);
            this.card.Controls.Add(this.label11);
            this.card.Depth = 0;
            this.card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card.Location = new System.Drawing.Point(23, 23);
            this.card.Margin = new System.Windows.Forms.Padding(14);
            this.card.MouseState = MaterialSkin.MouseState.HOVER;
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(14);
            this.card.Size = new System.Drawing.Size(444, 450);
            this.card.TabIndex = 159;
            // 
            // date_Pvj
            // 
            this.date_Pvj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_Pvj.BackColor = System.Drawing.Color.Transparent;
            this.date_Pvj.BorderRadius = 0;
            this.date_Pvj.ForeColor = System.Drawing.Color.Black;
            this.date_Pvj.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Pvj.FormatCustom = null;
            this.date_Pvj.Location = new System.Drawing.Point(37, 335);
            this.date_Pvj.Name = "date_Pvj";
            this.date_Pvj.Size = new System.Drawing.Size(364, 30);
            this.date_Pvj.TabIndex = 159;
            this.date_Pvj.Value = new System.DateTime(2021, 4, 30, 14, 1, 42, 86);
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox3.BorderThickness = 1;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(32, 328);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(375, 44);
            this.bunifuMetroTextbox3.TabIndex = 158;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_NumC
            // 
            this.cb_NumC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumC.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_NumC.FormattingEnabled = true;
            this.cb_NumC.Location = new System.Drawing.Point(43, 155);
            this.cb_NumC.Name = "cb_NumC";
            this.cb_NumC.Size = new System.Drawing.Size(358, 27);
            this.cb_NumC.TabIndex = 157;
            // 
            // txtarea_DateString
            // 
            this.txtarea_DateString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtarea_DateString.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_DateString.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_DateString.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_DateString.BorderThickness = 1;
            this.txtarea_DateString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtarea_DateString.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtarea_DateString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_DateString.isPassword = false;
            this.txtarea_DateString.Location = new System.Drawing.Point(34, 235);
            this.txtarea_DateString.Margin = new System.Windows.Forms.Padding(4);
            this.txtarea_DateString.Name = "txtarea_DateString";
            this.txtarea_DateString.Size = new System.Drawing.Size(375, 44);
            this.txtarea_DateString.TabIndex = 149;
            this.txtarea_DateString.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Adresse.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Adresse.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Adresse.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Adresse.BorderThickness = 1;
            this.txt_Adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Adresse.isPassword = false;
            this.txt_Adresse.Location = new System.Drawing.Point(34, 144);
            this.txt_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(375, 44);
            this.txt_Adresse.TabIndex = 148;
            this.txt_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_NumPvj
            // 
            this.cb_NumPvj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumPvj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumPvj.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_NumPvj.FormattingEnabled = true;
            this.cb_NumPvj.Location = new System.Drawing.Point(43, 69);
            this.cb_NumPvj.Name = "cb_NumPvj";
            this.cb_NumPvj.Size = new System.Drawing.Size(358, 27);
            this.cb_NumPvj.TabIndex = 145;
            this.cb_NumPvj.SelectedIndexChanged += new System.EventHandler(this.cb_NumPvj_SelectedIndexChanged);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(34, 60);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(375, 44);
            this.bunifuMetroTextbox1.TabIndex = 131;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Numéro de Pvj";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 89;
            this.label9.Text = "Consultation ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 96;
            this.label10.Text = "Date";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 98;
            this.label11.Text = "Date  ";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cb_fchoisie);
            this.materialCard1.Controls.Add(this.bunifuMetroTextbox2);
            this.materialCard1.Controls.Add(this.dgv_Fournisseur);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Controls.Add(this.dgv_Commission);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(489, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(454, 450);
            this.materialCard1.TabIndex = 160;
            // 
            // cb_fchoisie
            // 
            this.cb_fchoisie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_fchoisie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_fchoisie.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_fchoisie.FormattingEnabled = true;
            this.cb_fchoisie.Location = new System.Drawing.Point(32, 393);
            this.cb_fchoisie.Name = "cb_fchoisie";
            this.cb_fchoisie.Size = new System.Drawing.Size(381, 27);
            this.cb_fchoisie.TabIndex = 171;
            this.cb_fchoisie.SelectedIndexChanged += new System.EventHandler(this.cb_fchoisie_SelectedIndexChanged);
            this.cb_fchoisie.Click += new System.EventHandler(this.cb_fchoisie_Click_1);
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(23, 383);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(400, 44);
            this.bunifuMetroTextbox2.TabIndex = 160;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PvjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.card);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Modifier);
            this.Name = "PvjForm";
            this.Text = "PvjForm";
            this.Load += new System.EventHandler(this.PvjForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).EndInit();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Fournisseur;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Commission;
        private MaterialSkin.Controls.MaterialCard card;
        private System.Windows.Forms.ComboBox cb_NumC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtarea_DateString;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Adresse;
        private System.Windows.Forms.ComboBox cb_NumPvj;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDatepicker date_Pvj;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.ComboBox cb_fchoisie;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
    }
}