
namespace Projet_Onssa
{
    partial class ModeleDevisForm
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
            this.cb_NumMdevis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_MDevis = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Produits = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_NumF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_NumMdevis
            // 
            this.cb_NumMdevis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumMdevis.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_NumMdevis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumMdevis.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NumMdevis.FormattingEnabled = true;
            this.cb_NumMdevis.ItemHeight = 19;
            this.cb_NumMdevis.Location = new System.Drawing.Point(68, 190);
            this.cb_NumMdevis.Name = "cb_NumMdevis";
            this.cb_NumMdevis.Size = new System.Drawing.Size(376, 27);
            this.cb_NumMdevis.TabIndex = 66;
            this.cb_NumMdevis.SelectedIndexChanged += new System.EventHandler(this.cb_NumMdevis_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(68, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 21);
            this.label7.TabIndex = 65;
            this.label7.Text = "Numéro de Modele Devis";
            // 
            // date_MDevis
            // 
            this.date_MDevis.BackColor = System.Drawing.Color.Gainsboro;
            this.date_MDevis.BorderRadius = 0;
            this.date_MDevis.ForeColor = System.Drawing.Color.Black;
            this.date_MDevis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_MDevis.FormatCustom = null;
            this.date_MDevis.Location = new System.Drawing.Point(72, 342);
            this.date_MDevis.Margin = new System.Windows.Forms.Padding(4);
            this.date_MDevis.Name = "date_MDevis";
            this.date_MDevis.Size = new System.Drawing.Size(374, 27);
            this.date_MDevis.TabIndex = 62;
            this.date_MDevis.Value = new System.DateTime(2021, 4, 24, 15, 0, 22, 282);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Date  :";
            // 
            // dgv_Produits
            // 
            this.dgv_Produits.AllowUserToResizeColumns = false;
            this.dgv_Produits.AllowUserToResizeRows = false;
            this.dgv_Produits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produits.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Produits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Produits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Produits.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Produits.EnableHeadersVisualStyles = false;
            this.dgv_Produits.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Produits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Produits.Location = new System.Drawing.Point(501, 190);
            this.dgv_Produits.Name = "dgv_Produits";
            this.dgv_Produits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produits.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Produits.RowHeadersWidth = 4;
            this.dgv_Produits.Size = new System.Drawing.Size(416, 179);
            this.dgv_Produits.TabIndex = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unite";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantite";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix Unitaire";
            this.Column5.Name = "Column5";
            // 
            // cb_NumF
            // 
            this.cb_NumF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumF.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_NumF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumF.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NumF.FormattingEnabled = true;
            this.cb_NumF.ItemHeight = 19;
            this.cb_NumF.Location = new System.Drawing.Point(68, 271);
            this.cb_NumF.Name = "cb_NumF";
            this.cb_NumF.Size = new System.Drawing.Size(376, 27);
            this.cb_NumF.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(58, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 56);
            this.label5.TabIndex = 58;
            this.label5.Text = "Modele de devis";
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_Supprimer.Location = new System.Drawing.Point(430, 493);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.selected = false;
            this.btn_Supprimer.Size = new System.Drawing.Size(112, 48);
            this.btn_Supprimer.TabIndex = 57;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_Supprimer.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_Ajouter.Location = new System.Drawing.Point(312, 493);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.selected = false;
            this.btn_Ajouter.Size = new System.Drawing.Size(112, 48);
            this.btn_Ajouter.TabIndex = 56;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ajouter.Textcolor = System.Drawing.Color.White;
            this.btn_Ajouter.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_Modifier.Location = new System.Drawing.Point(548, 493);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.selected = false;
            this.btn_Modifier.Size = new System.Drawing.Size(112, 48);
            this.btn_Modifier.TabIndex = 55;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modifier.Textcolor = System.Drawing.Color.White;
            this.btn_Modifier.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Numéro de Fournisseur";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(497, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Produits :";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Supprimer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(827, 375);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(90, 27);
            this.bunifuFlatButton1.TabIndex = 67;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Vider";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(731, 375);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(90, 27);
            this.bunifuFlatButton2.TabIndex = 68;
            this.bunifuFlatButton2.Text = "Vider";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // ModeleDevisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.cb_NumMdevis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_MDevis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Produits);
            this.Controls.Add(this.cb_NumF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(970, 614);
            this.Name = "ModeleDevisForm";
            this.Text = "ModeleDevisForm";
            this.Load += new System.EventHandler(this.ModeleDevisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_NumMdevis;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker date_MDevis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Produits;
        private System.Windows.Forms.ComboBox cb_NumF;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Modifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}