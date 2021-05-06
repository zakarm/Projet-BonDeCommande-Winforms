using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
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

        private void openchildformtab(Form childForm1,Form childForm2)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm1 ;
            childForm1.TopLevel = false;
            childForm1.FormBorderStyle = FormBorderStyle.None;
            childForm1.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(childForm1);
            tabPage1.Tag = childForm1;
            childForm1.BringToFront();
            childForm1.Show();

            activeForm = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(childForm2);
            tabPage2.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();

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
                btn_Oi_Click(sender, e);
            }
            else
            {
                if(Program.OG.TypeCompte.Equals("csrs"))
                {
                   
                    btnPcsrs(true);
                    btnMcsrs(false);
                    btn_Consultation_Click(sender, e);
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
            panel_submenu.Visible = true;
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
            btn_Ov.Visible = s;
            panel_Op.Visible = s;
            btn_Op.Visible = s;
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
            btn_Ov.Visible = s;
            panel_Op.Visible = s;
            btn_Op.Visible = s;
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
            panel_submenu.Visible = true;
            if (Program.OG.TypeCompte.Equals("cord"))
            {
                btn_Oi_Click(sender, e);
                btnPcord(true);
            }
            else
            {
                if (Program.OG.TypeCompte.Equals("csrs"))
                {

                    btn_Consultation_Click(sender, e);
                    btnPcsrs(true);
                    btnMcsrs(false);
                }
            }

        }

        private void btn_Consultation_Click(object sender, EventArgs e)
        {
            label_txt.Text = "con";
            label_txt.Text = "Consultation";
            tabPage1.Text = "Lecture Consultation";
            tabPage2.Text = "Gestion Consultation";
            openchildformtab(new LectureConsultation(), new ConsultationForm());
            

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
            label_txt.Text = "Ordre d'imputation";
            label_txt.Name = "oi";
            openchildformtab(new LectureOi(), new OiForm());
            tabPage1.Text = "Lecture Ordre d'imputation";
            tabPage2.Text = "Gestion Ordre d'imputation";
            
        }

        private void btn_Pvr_Click(object sender, EventArgs e)
        {
            openchildform(new PvrForm());
            label_txt.Text = "Procès verbal de reception";
        }

        private void btn_Ov_Click(object sender, EventArgs e)
        {
               label_txt.Text = "Ordre de paiement";
            
            openchildformtab(new LectureOp(), new OpForm());
            tabPage1.Text = "Lecture Ordre de paiement";
            tabPage2.Text = "Gestion Ordre de paiement";
            
        }

        private void btn_Op_Click(object sender, EventArgs e)
        { 
            label_txt.Text = "Ordre de virement";
            label_txt.Name = "ov";
            openchildformtab(new LectureOv(),new OvForm());
            tabPage1.Text = "Lecture Ordre de virement";
            tabPage2.Text = "Gestion Ordre de virement";
            
        
        }

        private void btn_GestionCompte_Click(object sender, EventArgs e)
        {
            openchildform(new GestionCompteForm());
            panel_submenu.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (label_txt.Name)
            {
                case "con":
                    btn_Consultation_Click(sender, e);
                    break;
                case "op":
                    btn_Op_Click(sender, e);
                    break;
                case "oi":
                    btn_Oi_Click(sender, e);
                    break;
                case "ov":
                    btn_Ov_Click(sender, e);
                    break;
                
            }

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749); 
        }

        private void panelControl_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749); 
        }

        private void panelControl_MouseLeave(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);

        }

        private void btn_Accueil_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749);
        }

        private void btn_Accueil_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 
        }


        private void btn_Gpaiement_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 
        }

        private void btn_Gpaiement_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 
        }

        
        private void btn_Mamber_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749);
        }

        private void btn_Mamber_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 
        }

        private void btn_GestionCompte_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 
        }

        private void btn_GestionCompte_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(180, 749); 

        }

        private void panel_logo_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_logo_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_headermenu_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_headermenu_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Consultation_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Pvj_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Pvj_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Consultation_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Consultation_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Consultation_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_submenu_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_submenu_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Pvj_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Pvj_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Mdevis_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Mdevis_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Mdevis_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Mdevis_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Bc_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Bc_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Bc_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Bc_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Fe_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Fe_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Commission_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Commission_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Co_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Co_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Fr_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);

        }

        private void panel_Fr_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Fr_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Fr_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Op_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Op_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Op_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Op_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Ov_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Ov_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Ov_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Ov_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Pvr_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Pvr_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Pvr_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Pvr_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Oi_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Oi_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Oi_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void btn_Oi_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Fe_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }

        private void panel_Fe_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(64, 749);
        }
    }
}
