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
            }
        }

        private void btn_Consultation_Click(object sender, EventArgs e)
        {
            openchildform(new ConsultationForm());
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
            btnM(true);
            btnP(false);
        }

        private void btnP(bool s)
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
        private void btnM(bool s)
        {
            btn_Fr.Visible = s;
            panel_Fr.Visible = s;
        }

        private void btn_Gpaiement_Click(object sender, EventArgs e)
        {
            btnP(true);
            btnM(false);
        }

        private void btn_Fr_Click(object sender, EventArgs e)
        {
            openchildform(new FournisseurForm ());
        }
    }
}
