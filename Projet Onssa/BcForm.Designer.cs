
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
            this.cb_NumBc = new System.Windows.Forms.ComboBox();
            this.txt_Delai = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Destination = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Bc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cb_Pvj = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Morasse = new System.Windows.Forms.ComboBox();
            this.btn_Modifier = new Projet_Onssa.Button_WOC();
            this.btn_Ajouter = new Projet_Onssa.Button_WOC();
            this.btn_Supprimer = new Projet_Onssa.Button_WOC();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.menuStrip1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_NumBc
            // 
            this.cb_NumBc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_NumBc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_NumBc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumBc.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.cb_NumBc.FormattingEnabled = true;
            this.cb_NumBc.ItemHeight = 25;
            this.cb_NumBc.Location = new System.Drawing.Point(40, 84);
            this.cb_NumBc.Name = "cb_NumBc";
            this.cb_NumBc.Size = new System.Drawing.Size(351, 33);
            this.cb_NumBc.TabIndex = 140;
            this.cb_NumBc.SelectedIndexChanged += new System.EventHandler(this.cb_NumBc_SelectedIndexChanged);
            // 
            // txt_Delai
            // 
            this.txt_Delai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Delai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_Delai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Delai.Depth = 0;
            this.txt_Delai.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Delai.Location = new System.Drawing.Point(38, 264);
            this.txt_Delai.MaxLength = 50;
            this.txt_Delai.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Delai.Multiline = false;
            this.txt_Delai.Name = "txt_Delai";
            this.txt_Delai.Size = new System.Drawing.Size(353, 50);
            this.txt_Delai.TabIndex = 134;
            this.txt_Delai.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 143;
            this.label3.Text = "Delai Execution ";
            // 
            // txt_Destination
            // 
            this.txt_Destination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Destination.Depth = 0;
            this.txt_Destination.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_Destination.Location = new System.Drawing.Point(36, 164);
            this.txt_Destination.MaxLength = 50;
            this.txt_Destination.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Destination.Multiline = false;
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(353, 50);
            this.txt_Destination.TabIndex = 131;
            this.txt_Destination.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Num BC";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 142;
            this.label2.Text = "Destination";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 144;
            this.label4.Text = "Date";
            // 
            // date_Bc
            // 
            this.date_Bc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_Bc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.date_Bc.BorderRadius = 0;
            this.date_Bc.ForeColor = System.Drawing.Color.Black;
            this.date_Bc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Bc.FormatCustom = null;
            this.date_Bc.Location = new System.Drawing.Point(44, 272);
            this.date_Bc.Margin = new System.Windows.Forms.Padding(4);
            this.date_Bc.Name = "date_Bc";
            this.date_Bc.Size = new System.Drawing.Size(351, 47);
            this.date_Bc.TabIndex = 143;
            this.date_Bc.Value = new System.DateTime(2021, 4, 24, 15, 0, 22, 282);
            // 
            // cb_Pvj
            // 
            this.cb_Pvj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Pvj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_Pvj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Pvj.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Pvj.FormattingEnabled = true;
            this.cb_Pvj.ItemHeight = 25;
            this.cb_Pvj.Location = new System.Drawing.Point(44, 183);
            this.cb_Pvj.Name = "cb_Pvj";
            this.cb_Pvj.Size = new System.Drawing.Size(351, 33);
            this.cb_Pvj.TabIndex = 146;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(43, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 142;
            this.label7.Text = "Code Morasse";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(43, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 18);
            this.label6.TabIndex = 143;
            this.label6.Text = "Procès-verbal de jugement";
            // 
            // cb_Morasse
            // 
            this.cb_Morasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Morasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cb_Morasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Morasse.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Morasse.FormattingEnabled = true;
            this.cb_Morasse.ItemHeight = 25;
            this.cb_Morasse.Location = new System.Drawing.Point(44, 89);
            this.cb_Morasse.Name = "cb_Morasse";
            this.cb_Morasse.Size = new System.Drawing.Size(351, 33);
            this.cb_Morasse.TabIndex = 145;
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
            this.btn_Modifier.Location = new System.Drawing.Point(539, 28);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.Size = new System.Drawing.Size(114, 47);
            this.btn_Modifier.TabIndex = 145;
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
            this.btn_Ajouter.Location = new System.Drawing.Point(299, 26);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.Size = new System.Drawing.Size(114, 47);
            this.btn_Ajouter.TabIndex = 143;
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
            this.btn_Supprimer.Location = new System.Drawing.Point(419, 26);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 47);
            this.btn_Supprimer.TabIndex = 144;
            this.btn_Supprimer.Text = "SUPPRIMER";
            this.btn_Supprimer.TextColor = System.Drawing.Color.White;
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viderToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
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
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 50;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuCards2.Controls.Add(this.date_Bc);
            this.bunifuCards2.Controls.Add(this.cb_Pvj);
            this.bunifuCards2.Controls.Add(this.label7);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.Controls.Add(this.cb_Morasse);
            this.bunifuCards2.Controls.Add(this.label4);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(495, 46);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(465, 434);
            this.bunifuCards2.TabIndex = 149;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 50;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuCards1.Controls.Add(this.cb_NumBc);
            this.bunifuCards1.Controls.Add(this.txt_Delai);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.txt_Destination);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(21, 46);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(465, 434);
            this.bunifuCards1.TabIndex = 150;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 50;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.White;
            this.bunifuCards3.Controls.Add(this.btn_Modifier);
            this.bunifuCards3.Controls.Add(this.btn_Ajouter);
            this.bunifuCards3.Controls.Add(this.btn_Supprimer);
            this.bunifuCards3.LeftSahddow = true;
            this.bunifuCards3.Location = new System.Drawing.Point(21, 488);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(945, 97);
            this.bunifuCards3.TabIndex = 151;
            // 
            // BcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BcForm";
            this.Text = "BcForm";
            this.Load += new System.EventHandler(this.BcForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NumBc;
        private MaterialSkin.Controls.MaterialTextBox txt_Destination;
        private MaterialSkin.Controls.MaterialTextBox txt_Delai;
        private Bunifu.Framework.UI.BunifuDatepicker date_Bc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Pvj;
        private System.Windows.Forms.ComboBox cb_Morasse;
        private Button_WOC btn_Modifier;
        private Button_WOC btn_Ajouter;
        private Button_WOC btn_Supprimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viderToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
    }
}