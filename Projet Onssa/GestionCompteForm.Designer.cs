﻿
namespace Projet_Onssa
{
    partial class GestionCompteForm
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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.card = new MaterialSkin.Controls.MaterialCard();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cb_Numcompte = new System.Windows.Forms.ComboBox();
            this.txt_motdepasse = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_conf_mot_de_passe = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_typeccompte = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.materialCard3.SuspendLayout();
            this.card.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.bunifuFlatButton1);
            this.materialCard3.Controls.Add(this.bunifuFlatButton2);
            this.materialCard3.Controls.Add(this.bunifuFlatButton3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(20, 476);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(916, 76);
            this.materialCard3.TabIndex = 159;
            // 
            // card
            // 
            this.card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card.Controls.Add(this.txt_typeccompte);
            this.card.Controls.Add(this.txt_conf_mot_de_passe);
            this.card.Controls.Add(this.txt_motdepasse);
            this.card.Controls.Add(this.cb_Numcompte);
            this.card.Controls.Add(this.bunifuMetroTextbox1);
            this.card.Controls.Add(this.label4);
            this.card.Controls.Add(this.label5);
            this.card.Controls.Add(this.label6);
            this.card.Controls.Add(this.label7);
            this.card.Depth = 0;
            this.card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card.Location = new System.Drawing.Point(20, 23);
            this.card.Margin = new System.Windows.Forms.Padding(14);
            this.card.MouseState = MaterialSkin.MouseState.HOVER;
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(14);
            this.card.Size = new System.Drawing.Size(916, 438);
            this.card.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(298, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 98;
            this.label7.Text = "Type de compte";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(298, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 21);
            this.label6.TabIndex = 96;
            this.label6.Text = "Confirmation du mot de passe";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(298, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 89;
            this.label5.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(298, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 90;
            this.label4.Text = "Nom \r\n";
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
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(302, 76);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(375, 44);
            this.bunifuMetroTextbox1.TabIndex = 131;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_Numcompte
            // 
            this.cb_Numcompte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Numcompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Numcompte.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_Numcompte.FormattingEnabled = true;
            this.cb_Numcompte.Location = new System.Drawing.Point(311, 85);
            this.cb_Numcompte.Name = "cb_Numcompte";
            this.cb_Numcompte.Size = new System.Drawing.Size(358, 27);
            this.cb_Numcompte.TabIndex = 145;
            // 
            // txt_motdepasse
            // 
            this.txt_motdepasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_motdepasse.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_motdepasse.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_motdepasse.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_motdepasse.BorderThickness = 1;
            this.txt_motdepasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_motdepasse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_motdepasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_motdepasse.isPassword = false;
            this.txt_motdepasse.Location = new System.Drawing.Point(302, 160);
            this.txt_motdepasse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_motdepasse.Name = "txt_motdepasse";
            this.txt_motdepasse.Size = new System.Drawing.Size(375, 44);
            this.txt_motdepasse.TabIndex = 148;
            this.txt_motdepasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_conf_mot_de_passe
            // 
            this.txt_conf_mot_de_passe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_conf_mot_de_passe.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_conf_mot_de_passe.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_conf_mot_de_passe.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_conf_mot_de_passe.BorderThickness = 1;
            this.txt_conf_mot_de_passe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conf_mot_de_passe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_conf_mot_de_passe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_conf_mot_de_passe.isPassword = false;
            this.txt_conf_mot_de_passe.Location = new System.Drawing.Point(302, 251);
            this.txt_conf_mot_de_passe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conf_mot_de_passe.Name = "txt_conf_mot_de_passe";
            this.txt_conf_mot_de_passe.Size = new System.Drawing.Size(375, 44);
            this.txt_conf_mot_de_passe.TabIndex = 149;
            this.txt_conf_mot_de_passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_typeccompte
            // 
            this.txt_typeccompte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_typeccompte.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_typeccompte.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_typeccompte.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txt_typeccompte.BorderThickness = 1;
            this.txt_typeccompte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_typeccompte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_typeccompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_typeccompte.isPassword = false;
            this.txt_typeccompte.Location = new System.Drawing.Point(302, 337);
            this.txt_typeccompte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_typeccompte.Name = "txt_typeccompte";
            this.txt_typeccompte.Size = new System.Drawing.Size(375, 44);
            this.txt_typeccompte.TabIndex = 150;
            this.txt_typeccompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(439, 11);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(112, 48);
            this.bunifuFlatButton1.TabIndex = 151;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Ajouter";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(321, 11);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(112, 48);
            this.bunifuFlatButton2.TabIndex = 150;
            this.bunifuFlatButton2.Text = "Ajouter";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.bunifuFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "Modifier";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(557, 11);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(112, 48);
            this.bunifuFlatButton3.TabIndex = 149;
            this.bunifuFlatButton3.Text = "Modifier";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // GestionCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.card);
            this.Controls.Add(this.materialCard3);
            this.Name = "GestionCompteForm";
            this.Text = "GestionCompteForm";
            this.Load += new System.EventHandler(this.GestionCompteForm_Load);
            this.materialCard3.ResumeLayout(false);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard card;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_typeccompte;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_conf_mot_de_passe;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_motdepasse;
        private System.Windows.Forms.ComboBox cb_Numcompte;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}