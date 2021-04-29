using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Onssa
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        
        private Form activeForm = null;
        private void openchildform(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childform.Controls.Add(childForm);
            panel_childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Accueil_Load(object sender, EventArgs e)
        {
            if (Program.OG.TypeCompte.Equals("cord"))
            {
                btnPcord(true);
            }
            else
            {
                if(Program.OG.TypeCompte.Equals("csrs"))
                {
                    btnPcsrs(true);
                    btnMcsrs(false);
                }
                else
                {
                    if(Program.OG.TypeCompte.Equals("dr"))
                    {
                        btnMcsrs(false);
                        btnPcsrs(false);
                        btnPcord(false);
                        btn_Gpaiement.Visible = false;
                    }
                }
            }
        }

        
        private void btn_Out_Click(object sender, EventArgs e)
        {
            this.Hide();

            Connexion c = new Connexion();
            c.Show();
 
            Accueil a = new Accueil();
            a.Close();
        }

        private void btn_Mamber_Click(object sender, EventArgs e)
        {
            btnPcsrs(false);
            btnMcsrs(true);
            
        }

        private void btnPcord(bool s)
        {
            btn_Consultation.Visible = false;
            panel_Consultation.Visible = false;
            btn_Pvj.Visible = false;
            panel_Pvj.Visible = false;
            btn_Mdevis.Visible = false;
            panel_Mdevis.Visible = false;
            btn_Bc.Visible = false;
            panel_Bc.Visible = false;
            btn_Fe.Visible = false;
            panel_Fe.Visible = false;
            btn_Oi.Visible = false;
            panel_Oi.Visible = false;
            btn_Mamber.Visible = false;
            btn_Co.Visible = false;
            btn_Fr.Visible = false;
            panel_Fr.Visible = false;
            btn_GestionCompte.Visible = false;
            btn_Mamber.Visible = false;

            btn_Pvr.Visible = s;
            panel_Pvr.Visible = s;
            btn_Op.Visible = s;
            panel_Op.Visible = s;
            btn_Ov.Visible = s;
            panel_Ov.Visible = s;
        }

        private void btnPcsrs(bool s)
        {

            btn_Consultation.Visible = s;
            panel_Consultation.Visible = s;
            btn_Pvj.Visible = s;
            panel_Pvj.Visible = s;
            btn_Mdevis.Visible = s;
            panel_Mdevis.Visible = s;
            btn_Bc.Visible = s;
            panel_Bc.Visible =s;
            btn_Fe.Visible = s;
            panel_Fe.Visible = s;
            btn_Oi.Visible = s;
            panel_Oi.Visible = s;
            btn_Pvr.Visible = s;
            panel_Pvr.Visible = s;
            btn_Op.Visible = s;
            panel_Op.Visible = s;
            btn_Ov.Visible = s;
            panel_Ov.Visible = s;
        }
        private void btnMcsrs(bool s)
        {
            btn_Fr.Visible = s;
            panel_Fr.Visible = s;
            btn_Co.Visible = s;
            panel_Commission.Visible = s;
        }

        private void btn_Gpaiement_Click(object sender, EventArgs e)
        {
            if (Program.OG.TypeCompte.Equals("cord"))
            {
                btnPcord(true);
            }
            else
            {
                if (Program.OG.TypeCompte.Equals("csrs"))
                {
                    btnPcsrs(true);
                    btnMcsrs(false);
                }
            }

        }

        private void btn_Consultation_Click(object sender, EventArgs e)
        {
            openchildform(new ConsultationForm());
            label_txt.Text = "Consultation";
        }

        private void btn_Fr_Click(object sender, EventArgs e)
        {
            openchildform(new FournisseurForm());
            label_txt.Text = "Fournniseur";
        }

        private void btn_Co_Click(object sender, EventArgs e)
        {
            openchildform(new CommissionForm());
            label_txt.Text = "Commission";
        }

        private void btn_Pvj_Click(object sender, EventArgs e)
        {
            openchildform(new PvjForm());
            label_txt.Text = "Procès verbal de jugement";
        }

        private void btn_Mdevis_Click(object sender, EventArgs e)
        {
            openchildform(new ModeleDevisForm());
            label_txt.Text = "Modele Devis";
        }

        private void btn_Bc_Click(object sender, EventArgs e)
        {
            openchildform(new BcForm());
            label_txt.Text = "Bon de commande";
        }

        private void btn_Fe_Click(object sender, EventArgs e)
        {
            openchildform(new FeForm());
            label_txt.Text = "Fiche d'engagement";
        }

        private void btn_Oi_Click(object sender, EventArgs e)
        {
            openchildform(new OiForm());
            label_txt.Text = "Ordre d'imputation";
        }

        private void btn_Pvr_Click(object sender, EventArgs e)
        {
            openchildform(new PvrForm());
            label_txt.Text = "Procès verbal de reception";
        }

        private void btn_Ov_Click(object sender, EventArgs e)
        {
            openchildform(new OvForm());
            label_txt.Text = "Ordre de virement";
        }

        private void btn_Op_Click(object sender, EventArgs e)
        {
            openchildform(new OpForm());
            label_txt.Text = "Ordre de paiement";
        }
    }
}
