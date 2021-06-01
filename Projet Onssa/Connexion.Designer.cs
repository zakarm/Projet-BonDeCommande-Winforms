
namespace Projet_Onssa
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.panel_content = new System.Windows.Forms.Panel();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cnx = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_banner = new System.Windows.Forms.Panel();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_content.BackColor = System.Drawing.Color.White;
            this.panel_content.Controls.Add(this.txt_Password);
            this.panel_content.Controls.Add(this.label3);
            this.panel_content.Controls.Add(this.label2);
            this.panel_content.Controls.Add(this.label1);
            this.panel_content.Controls.Add(this.btn_Cnx);
            this.panel_content.Controls.Add(this.txt_Nom);
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(418, 521);
            this.panel_content.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.txt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Password.HintText = "";
            this.txt_Password.isPassword = true;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.LightGray;
            this.txt_Password.LineIdleColor = System.Drawing.Color.LightGray;
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.txt_Password.LineThickness = 3;
            this.txt_Password.Location = new System.Drawing.Point(36, 287);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(335, 44);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(32, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(107, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connexion";
            // 
            // btn_Cnx
            // 
            this.btn_Cnx.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Cnx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.btn_Cnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cnx.BorderRadius = 7;
            this.btn_Cnx.ButtonText = "Sign In";
            this.btn_Cnx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cnx.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cnx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_Cnx.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cnx.Iconimage = null;
            this.btn_Cnx.Iconimage_right = null;
            this.btn_Cnx.Iconimage_right_Selected = null;
            this.btn_Cnx.Iconimage_Selected = null;
            this.btn_Cnx.IconMarginLeft = 0;
            this.btn_Cnx.IconMarginRight = 0;
            this.btn_Cnx.IconRightVisible = true;
            this.btn_Cnx.IconRightZoom = 0D;
            this.btn_Cnx.IconVisible = true;
            this.btn_Cnx.IconZoom = 90D;
            this.btn_Cnx.IsTab = false;
            this.btn_Cnx.Location = new System.Drawing.Point(145, 386);
            this.btn_Cnx.Name = "btn_Cnx";
            this.btn_Cnx.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.btn_Cnx.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(253)))));
            this.btn_Cnx.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cnx.selected = false;
            this.btn_Cnx.Size = new System.Drawing.Size(142, 48);
            this.btn_Cnx.TabIndex = 11;
            this.btn_Cnx.Text = "Sign In";
            this.btn_Cnx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cnx.Textcolor = System.Drawing.Color.White;
            this.btn_Cnx.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cnx.Click += new System.EventHandler(this.btn_Cnx_Click);
            // 
            // txt_Nom
            // 
            this.txt_Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.txt_Nom.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nom.HintText = "";
            this.txt_Nom.isPassword = false;
            this.txt_Nom.LineFocusedColor = System.Drawing.Color.LightGray;
            this.txt_Nom.LineIdleColor = System.Drawing.Color.LightGray;
            this.txt_Nom.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.txt_Nom.LineThickness = 3;
            this.txt_Nom.Location = new System.Drawing.Point(36, 183);
            this.txt_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(335, 44);
            this.txt_Nom.TabIndex = 9;
            this.txt_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel_banner
            // 
            this.panel_banner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(75)))));
            this.panel_banner.BackgroundImage = global::Projet_Onssa.Properties.Resources.banner;
            this.panel_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_banner.Location = new System.Drawing.Point(424, 0);
            this.panel_banner.Name = "panel_banner";
            this.panel_banner.Size = new System.Drawing.Size(463, 521);
            this.panel_banner.TabIndex = 0;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(887, 524);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(998, 694);
            this.MinimumSize = new System.Drawing.Size(828, 524);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_banner;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cnx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
    }
}

