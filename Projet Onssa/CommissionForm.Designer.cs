
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Affectation = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Fonction = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Prenom = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_Modifier = new MaterialSkin.Controls.MaterialButton();
            this.btn_Supprimer = new MaterialSkin.Controls.MaterialButton();
            this.btn_Ajouter = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_Commission = new System.Windows.Forms.DataGridView();
            this.cb_Nom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(46, 116);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(35, 19);
            this.materialLabel4.TabIndex = 137;
            this.materialLabel4.Text = "Nom";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(46, 373);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 136;
            this.materialLabel3.Text = "Affectation";
            // 
            // txt_Affectation
            // 
            this.txt_Affectation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Affectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Affectation.Depth = 0;
            this.txt_Affectation.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Affectation.Location = new System.Drawing.Point(47, 395);
            this.txt_Affectation.MaxLength = 50;
            this.txt_Affectation.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Affectation.Multiline = false;
            this.txt_Affectation.Name = "txt_Affectation";
            this.txt_Affectation.Size = new System.Drawing.Size(353, 50);
            this.txt_Affectation.TabIndex = 135;
            this.txt_Affectation.Text = "";
            // 
            // txt_Fonction
            // 
            this.txt_Fonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Fonction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fonction.Depth = 0;
            this.txt_Fonction.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Fonction.Location = new System.Drawing.Point(47, 311);
            this.txt_Fonction.MaxLength = 50;
            this.txt_Fonction.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Fonction.Multiline = false;
            this.txt_Fonction.Name = "txt_Fonction";
            this.txt_Fonction.Size = new System.Drawing.Size(353, 50);
            this.txt_Fonction.TabIndex = 134;
            this.txt_Fonction.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(46, 289);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 133;
            this.materialLabel2.Text = "Fonction";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 132;
            this.materialLabel1.Text = "Prénom";
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Prenom.Depth = 0;
            this.txt_Prenom.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Prenom.Location = new System.Drawing.Point(47, 221);
            this.txt_Prenom.MaxLength = 50;
            this.txt_Prenom.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Prenom.Multiline = false;
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(353, 50);
            this.txt_Prenom.TabIndex = 131;
            this.txt_Prenom.Text = "";
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.Depth = 0;
            this.btn_Modifier.DrawShadows = true;
            this.btn_Modifier.HighEmphasis = true;
            this.btn_Modifier.Icon = null;
            this.btn_Modifier.Location = new System.Drawing.Point(535, 498);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Modifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(88, 36);
            this.btn_Modifier.TabIndex = 130;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Modifier.UseAccentColor = false;
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click_1);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Supprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.Depth = 0;
            this.btn_Supprimer.DrawShadows = true;
            this.btn_Supprimer.HighEmphasis = true;
            this.btn_Supprimer.Icon = null;
            this.btn_Supprimer.Location = new System.Drawing.Point(425, 498);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Supprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(102, 36);
            this.btn_Supprimer.TabIndex = 129;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Supprimer.UseAccentColor = false;
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click_1);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.Depth = 0;
            this.btn_Ajouter.DrawShadows = true;
            this.btn_Ajouter.HighEmphasis = true;
            this.btn_Ajouter.Icon = null;
            this.btn_Ajouter.Location = new System.Drawing.Point(332, 498);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(85, 36);
            this.btn_Ajouter.TabIndex = 128;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Ajouter.UseAccentColor = false;
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(472, 116);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(261, 19);
            this.materialLabel5.TabIndex = 139;
            this.materialLabel5.Text = "Commission dans la base de donnes";
            // 
            // dgv_Commission
            // 
            this.dgv_Commission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Commission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Commission.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv_Commission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Commission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Commission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Commission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Commission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Commission.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Commission.EnableHeadersVisualStyles = false;
            this.dgv_Commission.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Commission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Commission.Location = new System.Drawing.Point(475, 144);
            this.dgv_Commission.Name = "dgv_Commission";
            this.dgv_Commission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Commission.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Commission.RowHeadersWidth = 4;
            this.dgv_Commission.Size = new System.Drawing.Size(409, 301);
            this.dgv_Commission.TabIndex = 126;
            // 
            // cb_Nom
            // 
            this.cb_Nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_Nom.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nom.FormattingEnabled = true;
            this.cb_Nom.ItemHeight = 19;
            this.cb_Nom.Location = new System.Drawing.Point(47, 144);
            this.cb_Nom.Name = "cb_Nom";
            this.cb_Nom.Size = new System.Drawing.Size(351, 27);
            this.cb_Nom.TabIndex = 140;
            this.cb_Nom.SelectedIndexChanged += new System.EventHandler(this.cb_Nom_SelectedIndexChanged);
            // 
            // CommissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.cb_Nom);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_Affectation);
            this.Controls.Add(this.txt_Fonction);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.dgv_Commission);
            this.Name = "CommissionForm";
            this.Text = "Commission";
            this.Load += new System.EventHandler(this.CommissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_Affectation;
        private MaterialSkin.Controls.MaterialTextBox txt_Fonction;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_Prenom;
        private MaterialSkin.Controls.MaterialButton btn_Modifier;
        private MaterialSkin.Controls.MaterialButton btn_Supprimer;
        private MaterialSkin.Controls.MaterialButton btn_Ajouter;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgv_Commission;
        private System.Windows.Forms.ComboBox cb_Nom;
    }
}