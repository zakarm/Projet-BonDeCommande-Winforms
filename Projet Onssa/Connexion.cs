using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Projet_Onssa
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void btn_Cnx_Click(object sender, EventArgs e)
        {

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {

                txt_Password.isPassword = true;
                var query = from g in ctx.GestionCompteSet
                            where g.Nom == txt_Nom.Text && g.MotDePasse == txt_Password.Text
                            select g ;

                Program.OG = query.FirstOrDefault();
                if(Program.OG!=null)
                {
                    Accueil FormAcc = new Accueil();
                    this.Hide();
                    FormAcc.Show();
                    Connexion c = new Connexion();
                    c.Close();
                }
                else
                 MessageBox.Show("Compte Introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            txt_Password.isPassword = true;
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.isPassword = true;
        }
    }
}
