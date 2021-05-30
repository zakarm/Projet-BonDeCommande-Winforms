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
            if (Program.OG.TypeCompte.Equals("cord") || Program.OG.TypeCompte.Equals("Cord") || Program.OG.TypeCompte.Equals("CORD"))
            {

                btnPcord(true);
                btnLcsrs(false);
                btnMcsrs(false);
                panel_Mamber.Visible = false;
                btn_Lois.Visible = false;
                btn_Mamber.Visible = false;
                btn_GestionCompte.Visible = false;
                openchildform(new Statistique());
            }
            else
            {
                if(Program.OG.TypeCompte.Equals("csrs") || Program.OG.TypeCompte.Equals("CSRS") || Program.OG.TypeCompte.Equals("Csrs"))
                {
                   
                    btnPcsrs(true);
                    btnMcsrs(false);
                    btnLcsrs(false);
                    openchildform(new Statistique());

                }
                else
                {
                    if(Program.OG.TypeCompte.Equals("dr") || Program.OG.TypeCompte.Equals("Dr") || Program.OG.TypeCompte.Equals("DR"))
                    {
                        btn_Gpaiement_Click(sender, e);
                        btnPcsrs(true);
                        btnMcsrs(false);
                        btnLcsrs(false);
                        btn_Lois.Visible = false;
                        btn_Mamber.Visible = false;
                        panel_Mamber.Visible = false;
                        btn_GestionCompte.Visible = false;
                        panel_GestionCompte.Visible = false;
                        openchildform(new Statistique());
                    }
                    else
                    {

                        if (Program.OG.TypeCompte.Equals("ca") || Program.OG.TypeCompte.Equals("srs") || Program.OG.TypeCompte.Equals("CA") || 
                            Program.OG.TypeCompte.Equals("SRS") || Program.OG.TypeCompte.Equals("Ca") || Program.OG.TypeCompte.Equals("Srs"))
                        {

                            btnCcord(true);
                            btnLcsrs(false);
                            btnMcsrs(false);
                            panel_Mamber.Visible = false;
                            btn_Lois.Visible = false;
                            btn_Mamber.Visible = false;
                            btn_GestionCompte.Visible = false;
                            openchildform(new Statistique());
                        }

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

        private void btnCcord(bool s)
        {
            btn_Consultation.Visible = s;
            panel_Consultation.Visible = s;
            btn_Mddevis.Visible = false;
            panel_Pvj.Visible = s;
            btn_Pvj.Visible = s;
            panel_Mdevis.Visible = false;
            btn_Bc.Visible = s;
            panel_Bc.Visible = s;
            btn_Fe.Visible = s;
            panel_Fe.Visible = s;
            btn_Oi.Visible = false;
            panel_Oi.Visible = false;
            btn_Mamber.Visible = false;
            btn_Co.Visible = false;
            btn_Fr.Visible = false;
            panel_Fr.Visible = false;
            btn_GestionCompte.Visible = false;
            btn_Mamber.Visible = false;
            btn_Pvr.Visible = false;
            panel_Pvr.Visible = false;
            btn_Ov.Visible = false;
            panel_Op.Visible =false;
            btn_Op.Visible = false;
            panel_Ov.Visible = false;

        }

        private void btnPcord(bool s)
        {
            btn_Consultation.Visible = false;
            panel_Consultation.Visible = false;
            btn_Mddevis.Visible = false;
            panel_Pvj.Visible = false;
            btn_Pvj.Visible = false;
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

        private void btnLcsrs(bool s)
        {
            btn_ligne.Visible = s;
            panel_Ligne.Visible = s;
            btn_Lrg.Visible = s;
            panel_LRG.Visible = s;
            btn_Par.Visible = s;
            panel_Par.Visible = s;
            btn_Morasse.Visible = s;
            panel_Morasse.Visible = s;

        }
        private void btnPcsrs(bool s)
        {

            btn_Consultation.Visible = s;
            panel_Consultation.Visible = s;
            btn_Mddevis.Visible = s;
            panel_Pvj.Visible = s;
            btn_Pvj.Visible = s;
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
                btnMcsrs(false);
                
            }
            else
            {
                if (Program.OG.TypeCompte.Equals("csrs"))
                {

                    btn_Consultation_Click(sender, e);
                    btnPcsrs(true);
                    btnMcsrs(false);
                    btnLcsrs(false);
                }
                else
                {
                    if(Program.OG.TypeCompte.Equals("dr"))
                    {
                        btn_Consultation_Click(sender, e);
                        btnPcsrs(true);
                        tabControl1.TabPages.Remove(tabPage2);
                        
                        
                    }
                }
            }

        }

        private void btn_Consultation_Click(object sender, EventArgs e)
        {
            label_txt.Name = "con";
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

       

       

        private void btn_Bc_Click(object sender, EventArgs e)
        {
            label_txt.Text = "Bon de commande";
            label_txt.Name = "bc";
            openchildformtab(new LectureBc(), new BcForm());
            tabPage1.Text = "Lecture Bon de commande";
            tabPage2.Text = "Gestion Bon de commande";
        }

        private void btn_Fe_Click(object sender, EventArgs e)
        {
            label_txt.Text = "Fiche d'engagement";
            label_txt.Name = "fe";
            openchildformtab(new LectureFe(), new FeForm());
            tabPage1.Text = "Lecture Fiche d'engagement";
            tabPage2.Text = "Gestion Fiche d'engagement";
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
            tabPage1.Text = "Lecture Procès verbal de reception";
            tabPage2.Text = "Gestion Procès verbal de reception";
            label_txt.Name = "pvr";
            openchildformtab(new LecturePvr(),new PvrForm());
            label_txt.Text = "Procès verbal de reception";
        }

       
       

        private void btn_GestionCompte_Click(object sender, EventArgs e)
        {
            label_txt.Name = "Gestion Compte";
            openchildform(new GestionCompteForm());
            btnPcsrs(false);
            btnLcsrs(false);
            btnMcsrs(false);
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
                case "fe":
                    btn_Fe_Click(sender, e);
                    break;
                case "bc":
                    btn_Bc_Click(sender, e);
                    break;
                case "md":
                    btn_Mddevis_Click(sender, e);
                    break;
                case "pvr":
                    btn_Pvr_Click(sender, e);
                    break;
                case "pvj":
                    btn_Pvj_Click_1(sender, e);
                    break;

            }

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panelControl_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panelControl_MouseLeave(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);

        }

        private void btn_Accueil_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Accueil_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 
        }


        private void btn_Gpaiement_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 
        }

        private void btn_Gpaiement_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 
        }

        
        private void btn_Mamber_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Mamber_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 
        }

        private void btn_GestionCompte_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 
        }

        private void btn_GestionCompte_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749); 

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

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_GestionCompte_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btnLcsrs(true);
            btnMcsrs(false);
            btnPcsrs(false);
        }

        private void panel_Gpaiement_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Gpaiement_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Mamber_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Mamber_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Accueil_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Accueil_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Lrg_Click(object sender, EventArgs e)
        {
            label_txt.Name = "Lrg";
            openchildform(new LrgForm());
        }

        private void btn_Par_Click(object sender, EventArgs e)
        {
            label_txt.Name = "Paragraphe";
            openchildform(new ParagrapheForm());
        }

        private void btn_ligne_Click(object sender, EventArgs e)
        {
            label_txt.Name = "Ligne";
            openchildform(new LigneForm());
        }

        private void btn_Morasse_Click(object sender, EventArgs e)
        {
            label_txt.Name = "Morasse";
            openchildform(new MorasseForm());
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            label_txt.Name = "Guide";
            openchildform(new GuideApplication());
        }

        private void btn_Accueil_Click(object sender, EventArgs e)
        {
            openchildform(new Statistique());
        }

        private void btn_Pvj_Click_1(object sender, EventArgs e)
        {
            tabPage1.Text = "Lecture Procès verbal de jugement";
            tabPage2.Text = "Gestion Procès verbal de jugement";
            label_txt.Name = "pvj";
            openchildformtab(new LecturePvj(), new PvjForm());
            label_txt.Text = "Procès verbal de jugement";
        }

        private void btn_Mddevis_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Lecture Modele Devis";
            tabPage2.Text = "Gestion Modele Devis";
            label_txt.Name = "md";
            openchildformtab(new LectureMd(), new ModeleDevisForm());
            label_txt.Text = "Modele Devis";
        }

        private void btn_Op_Click(object sender, EventArgs e)
        {
            label_txt.Text = "Ordre de paiement";
            label_txt.Name = "op";
            openchildformtab(new LectureOp(), new OpForm());
            tabPage1.Text = "Lecture Ordre de paiement";
            tabPage2.Text = "Gestion Ordre de paiement";
        }

        private void btn_Ov_Click(object sender, EventArgs e)
        {
            label_txt.Text = "Ordre de virement";
            label_txt.Name = "ov";
            openchildformtab(new LectureOv(), new OvForm());
            tabPage1.Text = "Lecture Ordre de virement";
            tabPage2.Text = "Gestion Ordre de virement";
        }

        private void btn_Mamber_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Gpaiement_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Mamber_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_GestionCompte_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_GestionCompte_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Lois_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Gpaiement_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Accueil_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Accueil_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Accueil_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Accueil_MouseUp(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Gpaiement_MouseUp(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Gpaiement_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Mamber_MouseUp(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_Mamber_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_GestionCompte_MouseUp(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void panel_GestionCompte_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }

        private void btn_Lois_MouseUp(object sender, EventArgs e)
        {
            panelControl.Size = new Size(130, 749);
        }
    }
}
