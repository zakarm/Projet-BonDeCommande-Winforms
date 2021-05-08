
namespace Projet_Onssa
{
    partial class LigneForm
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
            this.cb_codeligne = new System.Windows.Forms.ComboBox();
            this.cb_codel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtarea_desc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Numlrg = new System.Windows.Forms.ComboBox();
            this.cb_codelrg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_codeligne
            // 
            this.cb_codeligne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_codeligne.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_codeligne.FormattingEnabled = true;
            this.cb_codeligne.Location = new System.Drawing.Point(58, 31);
            this.cb_codeligne.Name = "cb_codeligne";
            this.cb_codeligne.Size = new System.Drawing.Size(358, 25);
            this.cb_codeligne.TabIndex = 192;
            this.cb_codeligne.SelectedIndexChanged += new System.EventHandler(this.cb_codeligne_SelectedIndexChanged);
            // 
            // cb_codel
            // 
            this.cb_codel.BackColor = System.Drawing.Color.White;
            this.cb_codel.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.cb_codel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_codel.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.cb_codel.BorderThickness = 1;
            this.cb_codel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_codel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_codel.ForeColor = System.Drawing.Color.White;
            this.cb_codel.isPassword = false;
            this.cb_codel.Location = new System.Drawing.Point(49, 26);
            this.cb_codel.Margin = new System.Windows.Forms.Padding(4);
            this.cb_codel.Name = "cb_codel";
            this.cb_codel.Size = new System.Drawing.Size(375, 35);
            this.cb_codel.TabIndex = 190;
            this.cb_codel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 191;
            this.label2.Text = "Code Ligne";
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
            this.btn_Supprimer.Location = new System.Drawing.Point(177, 424);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supprimer.selected = false;
            this.btn_Supprimer.Size = new System.Drawing.Size(112, 48);
            this.btn_Supprimer.TabIndex = 186;
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
            this.btn_Ajouter.Location = new System.Drawing.Point(59, 424);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Ajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ajouter.selected = false;
            this.btn_Ajouter.Size = new System.Drawing.Size(112, 48);
            this.btn_Ajouter.TabIndex = 185;
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
            this.btn_Modifier.Location = new System.Drawing.Point(295, 424);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Modifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Modifier.selected = false;
            this.btn_Modifier.Size = new System.Drawing.Size(112, 48);
            this.btn_Modifier.TabIndex = 184;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modifier.Textcolor = System.Drawing.Color.White;
            this.btn_Modifier.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // txtarea_desc
            // 
            this.txtarea_desc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_desc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_desc.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.txtarea_desc.BorderThickness = 1;
            this.txtarea_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtarea_desc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtarea_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtarea_desc.isPassword = false;
            this.txtarea_desc.Location = new System.Drawing.Point(50, 187);
            this.txtarea_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txtarea_desc.Name = "txtarea_desc";
            this.txtarea_desc.Size = new System.Drawing.Size(375, 155);
            this.txtarea_desc.TabIndex = 183;
            this.txtarea_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 181;
            this.label6.Text = "Description Ligne :";
            // 
            // cb_Numlrg
            // 
            this.cb_Numlrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Numlrg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_Numlrg.FormattingEnabled = true;
            this.cb_Numlrg.Location = new System.Drawing.Point(58, 118);
            this.cb_Numlrg.Name = "cb_Numlrg";
            this.cb_Numlrg.Size = new System.Drawing.Size(358, 25);
            this.cb_Numlrg.TabIndex = 182;
            // 
            // cb_codelrg
            // 
            this.cb_codelrg.BackColor = System.Drawing.Color.White;
            this.cb_codelrg.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.cb_codelrg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_codelrg.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(239)))));
            this.cb_codelrg.BorderThickness = 1;
            this.cb_codelrg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_codelrg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cb_codelrg.ForeColor = System.Drawing.Color.White;
            this.cb_codelrg.isPassword = false;
            this.cb_codelrg.Location = new System.Drawing.Point(49, 113);
            this.cb_codelrg.Margin = new System.Windows.Forms.Padding(4);
            this.cb_codelrg.Name = "cb_codelrg";
            this.cb_codelrg.Size = new System.Drawing.Size(375, 35);
            this.cb_codelrg.TabIndex = 179;
            this.cb_codelrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 180;
            this.label8.Text = "Numéro de Lrg";
            // 
            // LigneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 498);
            this.Controls.Add(this.cb_codeligne);
            this.Controls.Add(this.cb_codel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.txtarea_desc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Numlrg);
            this.Controls.Add(this.cb_codelrg);
            this.Controls.Add(this.label8);
            this.Name = "LigneForm";
            this.Text = "LigneForm";
            this.Load += new System.EventHandler(this.LigneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_codeligne;
        private Bunifu.Framework.UI.BunifuMetroTextbox cb_codel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Modifier;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtarea_desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Numlrg;
        private Bunifu.Framework.UI.BunifuMetroTextbox cb_codelrg;
        private System.Windows.Forms.Label label8;
    }
}