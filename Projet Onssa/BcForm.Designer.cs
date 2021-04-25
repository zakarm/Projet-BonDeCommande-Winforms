
namespace Projet_Onssa
{
    partial class BcForm
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NumBc = new System.Windows.Forms.ComboBox();
            this.txt_Destination = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Delai = new MaterialSkin.Controls.MaterialTextBox();
            this.date_Bc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Morasse = new System.Windows.Forms.ComboBox();
            this.cb_Pvj = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Produit = new System.Windows.Forms.DataGridView();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btn_Modifier = new Projet_Onssa.Button_WOC();
            this.btn_Ajouter = new Projet_Onssa.Button_WOC();
            this.btn_Supprimer = new Projet_Onssa.Button_WOC();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produit)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.date_Bc);
            this.materialCard1.Controls.Add(this.cb_NumBc);
            this.materialCard1.Controls.Add(this.txt_Delai);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.txt_Destination);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 33);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(444, 438);
            this.materialCard1.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 144;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 143;
            this.label3.Text = "Delai Execution ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 142;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Num BC";
            // 
            // cb_NumBc
            // 
            this.cb_NumBc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumBc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_NumBc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumBc.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.cb_NumBc.FormattingEnabled = true;
            this.cb_NumBc.ItemHeight = 25;
            this.cb_NumBc.Location = new System.Drawing.Point(38, 70);
            this.cb_NumBc.Name = "cb_NumBc";
            this.cb_NumBc.Size = new System.Drawing.Size(351, 33);
            this.cb_NumBc.TabIndex = 140;
            this.cb_NumBc.SelectedIndexChanged += new System.EventHandler(this.cb_NumBc_SelectedIndexChanged);
            // 
            // txt_Destination
            // 
            this.txt_Destination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Destination.Depth = 0;
            this.txt_Destination.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Destination.Location = new System.Drawing.Point(38, 131);
            this.txt_Destination.MaxLength = 50;
            this.txt_Destination.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Destination.Multiline = false;
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(353, 50);
            this.txt_Destination.TabIndex = 131;
            this.txt_Destination.Text = "";
            // 
            // txt_Delai
            // 
            this.txt_Delai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Delai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_Delai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Delai.Depth = 0;
            this.txt_Delai.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Delai.Location = new System.Drawing.Point(38, 221);
            this.txt_Delai.MaxLength = 50;
            this.txt_Delai.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Delai.Multiline = false;
            this.txt_Delai.Name = "txt_Delai";
            this.txt_Delai.Size = new System.Drawing.Size(353, 50);
            this.txt_Delai.TabIndex = 134;
            this.txt_Delai.Text = "";
            // 
            // date_Bc
            // 
            this.date_Bc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.date_Bc.BorderRadius = 0;
            this.date_Bc.ForeColor = System.Drawing.Color.Black;
            this.date_Bc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Bc.FormatCustom = null;
            this.date_Bc.Location = new System.Drawing.Point(38, 308);
            this.date_Bc.Margin = new System.Windows.Forms.Padding(4);
            this.date_Bc.Name = "date_Bc";
            this.date_Bc.Size = new System.Drawing.Size(351, 47);
            this.date_Bc.TabIndex = 143;
            this.date_Bc.Value = new System.DateTime(2021, 4, 24, 15, 0, 22, 282);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgv_Produit);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.cb_Pvj);
            this.materialCard2.Controls.Add(this.label7);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.cb_Morasse);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(491, 33);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(444, 438);
            this.materialCard2.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(51, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 18);
            this.label6.TabIndex = 143;
            this.label6.Text = "Procès-verbal de jugement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(51, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 142;
            this.label7.Text = "Code Morasse";
            // 
            // cb_Morasse
            // 
            this.cb_Morasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Morasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_Morasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Morasse.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Morasse.FormattingEnabled = true;
            this.cb_Morasse.ItemHeight = 25;
            this.cb_Morasse.Location = new System.Drawing.Point(52, 54);
            this.cb_Morasse.Name = "cb_Morasse";
            this.cb_Morasse.Size = new System.Drawing.Size(351, 33);
            this.cb_Morasse.TabIndex = 145;
            // 
            // cb_Pvj
            // 
            this.cb_Pvj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Pvj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_Pvj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Pvj.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Pvj.FormattingEnabled = true;
            this.cb_Pvj.ItemHeight = 25;
            this.cb_Pvj.Location = new System.Drawing.Point(52, 123);
            this.cb_Pvj.Name = "cb_Pvj";
            this.cb_Pvj.Size = new System.Drawing.Size(351, 33);
            this.cb_Pvj.TabIndex = 146;
            this.cb_Pvj.SelectedIndexChanged += new System.EventHandler(this.cb_Pvj_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 147;
            this.label5.Text = "Produit";
            // 
            // dgv_Produit
            // 
            this.dgv_Produit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Produit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Produit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Produit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Produit.EnableHeadersVisualStyles = false;
            this.dgv_Produit.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Produit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Produit.Location = new System.Drawing.Point(52, 200);
            this.dgv_Produit.Name = "dgv_Produit";
            this.dgv_Produit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Produit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Produit.RowHeadersWidth = 4;
            this.dgv_Produit.Size = new System.Drawing.Size(351, 205);
            this.dgv_Produit.TabIndex = 148;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btn_Modifier);
            this.materialCard3.Controls.Add(this.btn_Ajouter);
            this.materialCard3.Controls.Add(this.btn_Supprimer);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(20, 485);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(916, 72);
            this.materialCard3.TabIndex = 147;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.FlatAppearance.BorderSize = 0;
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modifier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Modifier.Location = new System.Drawing.Point(513, 17);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.Size = new System.Drawing.Size(114, 41);
            this.btn_Modifier.TabIndex = 145;
            this.btn_Modifier.Text = "MODIFIER";
            this.btn_Modifier.TextColor = System.Drawing.Color.White;
            this.btn_Modifier.UseVisualStyleBackColor = false;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter.Location = new System.Drawing.Point(273, 16);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.Size = new System.Drawing.Size(114, 41);
            this.btn_Ajouter.TabIndex = 143;
            this.btn_Ajouter.Text = "AJOUTER";
            this.btn_Ajouter.TextColor = System.Drawing.Color.White;
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Supprimer.Location = new System.Drawing.Point(393, 16);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 41);
            this.btn_Supprimer.TabIndex = 144;
            this.btn_Supprimer.Text = "SUPPRIMER";
            this.btn_Supprimer.TextColor = System.Drawing.Color.White;
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 25);
            this.menuStrip1.TabIndex = 148;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viderToolStripMenuItem
            // 
            this.viderToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viderToolStripMenuItem.Name = "viderToolStripMenuItem";
            this.viderToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.viderToolStripMenuItem.Text = "Vider";
            this.viderToolStripMenuItem.Click += new System.EventHandler(this.viderToolStripMenuItem_Click);
            // 
            // BcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BcForm";
            this.Text = "BcForm";
            this.Load += new System.EventHandler(this.BcForm_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produit)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NumBc;
        private MaterialSkin.Controls.MaterialTextBox txt_Destination;
        private MaterialSkin.Controls.MaterialTextBox txt_Delai;
        private Bunifu.Framework.UI.BunifuDatepicker date_Bc;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Pvj;
        private System.Windows.Forms.ComboBox cb_Morasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Produit;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Button_WOC btn_Modifier;
        private Button_WOC btn_Ajouter;
        private Button_WOC btn_Supprimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viderToolStripMenuItem;
    }
}