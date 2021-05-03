
namespace Projet_Onssa
{
    partial class CommissionForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Commission = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Modifier = new Projet_Onssa.Button_WOC();
            this.btn_Ajouter = new Projet_Onssa.Button_WOC();
            this.btn_Supprimer = new Projet_Onssa.Button_WOC();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txt_Affectation = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Fonction = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Prenom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Nom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 145;
            this.label5.Text = "Commission dans la base de donnes";
            // 
            // dgv_Commission
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Commission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Commission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Commission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Commission.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Commission.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Commission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Commission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Commission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Commission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Commission.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Commission.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Commission.DoubleBuffered = true;
            this.dgv_Commission.EnableHeadersVisualStyles = false;
            this.dgv_Commission.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.dgv_Commission.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Commission.Location = new System.Drawing.Point(21, 79);
            this.dgv_Commission.Name = "dgv_Commission";
            this.dgv_Commission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Commission.RowHeadersWidth = 5;
            this.dgv_Commission.Size = new System.Drawing.Size(431, 454);
            this.dgv_Commission.TabIndex = 146;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.FlatAppearance.BorderSize = 0;
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modifier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Modifier.Location = new System.Drawing.Point(294, 19);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.Size = new System.Drawing.Size(134, 52);
            this.btn_Modifier.TabIndex = 7;
            this.btn_Modifier.Text = "MODIFIER";
            this.btn_Modifier.TextColor = System.Drawing.Color.White;
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter.Location = new System.Drawing.Point(14, 19);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.Size = new System.Drawing.Size(134, 52);
            this.btn_Ajouter.TabIndex = 5;
            this.btn_Ajouter.Text = "AJOUTER";
            this.btn_Ajouter.TextColor = System.Drawing.Color.White;
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Supprimer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Supprimer.Location = new System.Drawing.Point(154, 19);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.Size = new System.Drawing.Size(134, 52);
            this.btn_Supprimer.TabIndex = 6;
            this.btn_Supprimer.Text = "SUPPRIMER";
            this.btn_Supprimer.TextColor = System.Drawing.Color.White;
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_Affectation);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Controls.Add(this.txt_Fonction);
            this.materialCard1.Controls.Add(this.txt_Prenom);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.cb_Nom);
            this.materialCard1.Controls.Add(this.label7);
            this.materialCard1.Controls.Add(this.bunifuMetroTextbox1);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 32);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(453, 449);
            this.materialCard1.TabIndex = 155;
            // 
            // txt_Affectation
            // 
            this.txt_Affectation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Affectation.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Affectation.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Affectation.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Affectation.BorderThickness = 1;
            this.txt_Affectation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Affectation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Affectation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Affectation.isPassword = false;
            this.txt_Affectation.Location = new System.Drawing.Point(40, 329);
            this.txt_Affectation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Affectation.Name = "txt_Affectation";
            this.txt_Affectation.Size = new System.Drawing.Size(375, 44);
            this.txt_Affectation.TabIndex = 148;
            this.txt_Affectation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 147;
            this.label9.Text = "Affectation";
            // 
            // txt_Fonction
            // 
            this.txt_Fonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Fonction.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Fonction.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Fonction.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Fonction.BorderThickness = 1;
            this.txt_Fonction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fonction.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Fonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Fonction.isPassword = false;
            this.txt_Fonction.Location = new System.Drawing.Point(41, 246);
            this.txt_Fonction.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fonction.Name = "txt_Fonction";
            this.txt_Fonction.Size = new System.Drawing.Size(375, 44);
            this.txt_Fonction.TabIndex = 146;
            this.txt_Fonction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Prenom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Prenom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Prenom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Prenom.BorderThickness = 1;
            this.txt_Prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Prenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Prenom.isPassword = false;
            this.txt_Prenom.Location = new System.Drawing.Point(40, 165);
            this.txt_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(375, 44);
            this.txt_Prenom.TabIndex = 145;
            this.txt_Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 142;
            this.label6.Text = "Prénom";
            // 
            // cb_Nom
            // 
            this.cb_Nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Nom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Nom.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_Nom.FormattingEnabled = true;
            this.cb_Nom.Location = new System.Drawing.Point(49, 95);
            this.cb_Nom.Name = "cb_Nom";
            this.cb_Nom.Size = new System.Drawing.Size(358, 27);
            this.cb_Nom.TabIndex = 144;
            this.cb_Nom.SelectedIndexChanged += new System.EventHandler(this.cb_Nom_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 143;
            this.label7.Text = "Fonction";
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
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(40, 86);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(375, 44);
            this.bunifuMetroTextbox1.TabIndex = 130;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 141;
            this.label8.Text = "Nom";
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btn_Modifier);
            this.materialCard3.Controls.Add(this.btn_Supprimer);
            this.materialCard3.Controls.Add(this.btn_Ajouter);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(23, 494);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(453, 97);
            this.materialCard3.TabIndex = 157;
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.dgv_Commission);
            this.materialCard4.Controls.Add(this.label5);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(492, 32);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(469, 559);
            this.materialCard4.TabIndex = 158;
            // 
            // CommissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard1);
            this.MinimumSize = new System.Drawing.Size(941, 592);
            this.Name = "CommissionForm";
            this.Text = "CommissionForm";
            this.Load += new System.EventHandler(this.CommissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button_WOC btn_Ajouter;
        private Button_WOC btn_Supprimer;
        private Button_WOC btn_Modifier;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Commission;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Fonction;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Prenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Nom;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Affectation;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
    }
}