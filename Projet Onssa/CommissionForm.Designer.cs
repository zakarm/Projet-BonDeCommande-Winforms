
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
            this.txt_Affectation = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Fonction = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_Nom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Prenom = new MaterialSkin.Controls.MaterialTextBox();
            this.dgv_Commission = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_Modifier = new Projet_Onssa.Button_WOC();
            this.btn_Ajouter = new Projet_Onssa.Button_WOC();
            this.btn_Supprimer = new Projet_Onssa.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Affectation
            // 
            this.txt_Affectation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Affectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Affectation.Depth = 0;
            this.txt_Affectation.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Affectation.Location = new System.Drawing.Point(43, 320);
            this.txt_Affectation.MaxLength = 50;
            this.txt_Affectation.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Affectation.Multiline = false;
            this.txt_Affectation.Name = "txt_Affectation";
            this.txt_Affectation.Size = new System.Drawing.Size(374, 50);
            this.txt_Affectation.TabIndex = 3;
            this.txt_Affectation.Text = "";
            // 
            // txt_Fonction
            // 
            this.txt_Fonction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Fonction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fonction.Depth = 0;
            this.txt_Fonction.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Fonction.Location = new System.Drawing.Point(43, 228);
            this.txt_Fonction.MaxLength = 50;
            this.txt_Fonction.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Fonction.Multiline = false;
            this.txt_Fonction.Name = "txt_Fonction";
            this.txt_Fonction.Size = new System.Drawing.Size(374, 50);
            this.txt_Fonction.TabIndex = 2;
            this.txt_Fonction.Text = "";
            // 
            // cb_Nom
            // 
            this.cb_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Nom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Nom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Nom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Nom.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nom.FormattingEnabled = true;
            this.cb_Nom.IntegralHeight = false;
            this.cb_Nom.ItemHeight = 25;
            this.cb_Nom.Location = new System.Drawing.Point(43, 54);
            this.cb_Nom.Name = "cb_Nom";
            this.cb_Nom.Size = new System.Drawing.Size(374, 33);
            this.cb_Nom.TabIndex = 10;
            this.cb_Nom.SelectedIndexChanged += new System.EventHandler(this.cb_Nom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(53, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 144;
            this.label4.Text = "Affectation";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 143;
            this.label3.Text = "Fonction";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 142;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Nom";
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Prenom.Depth = 0;
            this.txt_Prenom.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Prenom.Location = new System.Drawing.Point(43, 133);
            this.txt_Prenom.MaxLength = 50;
            this.txt_Prenom.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Prenom.Multiline = false;
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(374, 50);
            this.txt_Prenom.TabIndex = 1;
            this.txt_Prenom.Text = "";
            // 
            // dgv_Commission
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Commission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Commission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Commission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Commission.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Commission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Commission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Commission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Commission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Commission.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Commission.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Commission.DoubleBuffered = true;
            this.dgv_Commission.EnableHeadersVisualStyles = false;
            this.dgv_Commission.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dgv_Commission.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Commission.Location = new System.Drawing.Point(20, 85);
            this.dgv_Commission.Name = "dgv_Commission";
            this.dgv_Commission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Commission.RowHeadersWidth = 5;
            this.dgv_Commission.Size = new System.Drawing.Size(414, 311);
            this.dgv_Commission.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 18);
            this.label5.TabIndex = 145;
            this.label5.Text = "Commission dans la base de donnes";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 50;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuCards1.Controls.Add(this.cb_Nom);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.txt_Affectation);
            this.bunifuCards1.Controls.Add(this.txt_Fonction);
            this.bunifuCards1.Controls.Add(this.txt_Prenom);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(22, 32);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(465, 434);
            this.bunifuCards1.TabIndex = 146;
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
            this.bunifuCards2.Controls.Add(this.dgv_Commission);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(493, 32);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(465, 434);
            this.bunifuCards2.TabIndex = 147;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 50;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuCards3.Controls.Add(this.btn_Modifier);
            this.bunifuCards3.Controls.Add(this.btn_Ajouter);
            this.bunifuCards3.Controls.Add(this.btn_Supprimer);
            this.bunifuCards3.LeftSahddow = true;
            this.bunifuCards3.Location = new System.Drawing.Point(22, 483);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(945, 101);
            this.bunifuCards3.TabIndex = 148;
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
            this.btn_Modifier.Location = new System.Drawing.Point(531, 24);
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
            this.btn_Ajouter.Location = new System.Drawing.Point(251, 24);
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
            this.btn_Supprimer.Location = new System.Drawing.Point(391, 24);
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
            // CommissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.MinimumSize = new System.Drawing.Size(941, 592);
            this.Name = "CommissionForm";
            this.Text = "Commission";
            this.Load += new System.EventHandler(this.CommissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_Affectation;
        private MaterialSkin.Controls.MaterialTextBox txt_Fonction;
        private Button_WOC btn_Ajouter;
        private Button_WOC btn_Supprimer;
        private Button_WOC btn_Modifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Commission;
        private System.Windows.Forms.ComboBox cb_Nom;
        private MaterialSkin.Controls.MaterialTextBox txt_Prenom;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
    }
}