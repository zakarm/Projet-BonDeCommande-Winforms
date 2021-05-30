
namespace Projet_Onssa
{
    partial class OpForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_Op = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Oi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Adresse = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_NumOp = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Modifier = new Projet_Onssa.Button_WOC();
            this.btn_Ajouter = new Projet_Onssa.Button_WOC();
            this.btn_Supprimer = new Projet_Onssa.Button_WOC();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.date_Op);
            this.panel1.Controls.Add(this.bunifuMetroTextbox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_Oi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Adresse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_NumOp);
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Location = new System.Drawing.Point(268, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 433);
            this.panel1.TabIndex = 169;
            // 
            // date_Op
            // 
            this.date_Op.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_Op.BackColor = System.Drawing.Color.Transparent;
            this.date_Op.BorderRadius = 0;
            this.date_Op.ForeColor = System.Drawing.Color.Black;
            this.date_Op.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Op.FormatCustom = null;
            this.date_Op.Location = new System.Drawing.Point(42, 294);
            this.date_Op.Name = "date_Op";
            this.date_Op.Size = new System.Drawing.Size(364, 30);
            this.date_Op.TabIndex = 166;
            this.date_Op.Value = new System.DateTime(2021, 4, 30, 14, 1, 42, 86);
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox3.BorderThickness = 1;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(34, 292);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(375, 35);
            this.bunifuMetroTextbox3.TabIndex = 165;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 164;
            this.label4.Text = "Date Op ";
            // 
            // cb_Oi
            // 
            this.cb_Oi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Oi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Oi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_Oi.FormattingEnabled = true;
            this.cb_Oi.Location = new System.Drawing.Point(43, 220);
            this.cb_Oi.Name = "cb_Oi";
            this.cb_Oi.Size = new System.Drawing.Size(358, 25);
            this.cb_Oi.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 158;
            this.label3.Text = "Ordre d\'imputation";
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Adresse.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Adresse.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Adresse.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_Adresse.BorderThickness = 1;
            this.txt_Adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Adresse.isPassword = false;
            this.txt_Adresse.Location = new System.Drawing.Point(35, 216);
            this.txt_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(375, 35);
            this.txt_Adresse.TabIndex = 162;
            this.txt_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 21);
            this.label5.TabIndex = 159;
            this.label5.Text = "Numéro Ordre du paeiment";
            // 
            // cb_NumOp
            // 
            this.cb_NumOp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_NumOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_NumOp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_NumOp.FormattingEnabled = true;
            this.cb_NumOp.Location = new System.Drawing.Point(43, 139);
            this.cb_NumOp.Name = "cb_NumOp";
            this.cb_NumOp.Size = new System.Drawing.Size(358, 25);
            this.cb_NumOp.TabIndex = 161;
            this.cb_NumOp.SelectedIndexChanged += new System.EventHandler(this.cb_NumOp_SelectedIndexChanged_1);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(35, 134);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(375, 35);
            this.bunifuMetroTextbox1.TabIndex = 160;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Modifier);
            this.panel3.Controls.Add(this.btn_Ajouter);
            this.panel3.Controls.Add(this.btn_Supprimer);
            this.panel3.Location = new System.Drawing.Point(268, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 72);
            this.panel3.TabIndex = 170;
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
            this.btn_Modifier.Location = new System.Drawing.Point(282, 15);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.Size = new System.Drawing.Size(114, 41);
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
            this.btn_Ajouter.Location = new System.Drawing.Point(42, 14);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.Size = new System.Drawing.Size(114, 41);
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
            this.btn_Supprimer.Location = new System.Drawing.Point(162, 14);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Supprimer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 41);
            this.btn_Supprimer.TabIndex = 144;
            this.btn_Supprimer.Text = "SUPPRIMER";
            this.btn_Supprimer.TextColor = System.Drawing.Color.White;
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // OpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "OpForm";
            this.Text = "OpForm";
            this.Load += new System.EventHandler(this.OpForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button_WOC btn_Modifier;
        private Button_WOC btn_Ajouter;
        private Button_WOC btn_Supprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Oi;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_NumOp;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuDatepicker date_Op;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}