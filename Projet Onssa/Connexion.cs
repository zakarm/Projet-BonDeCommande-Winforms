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
                //connection string= &quot; Data Source=DESKTOP-IRG7UCK\SQLEXPRESS;Initial Catalog=Onssa_Projet;Integrated Security=True; MultipleActiveResultSets=True;App=EntityFramework&quot;
                // connectionString="&quot; Data Source=DESKTOP-IRG7UCK\SQLEXPRESS;Initial Catalog=Onssa_Projet;Integrated Security=True"
                ///////////methode recherche simple//////////////

                //bool teste = false;
                //foreach(GestionCompte OG in o.GestionCompteSet)
                //{
                //    if(OG.Nom== bunifuMaterialTextbox4.Text && OG.MotDePasse== bunifuMaterialTextbox3.Text)
                //    {
                //        Program.typeCompte = OG.TypeCompte;
                //        teste = true;
                //        break;
                //    }
                //}

                //if (teste == true)
                //{
                //    Accueil FormAcc = new Accueil();
                //    this.Hide();
                //    FormAcc.Show();
                //}

                //else
                //    MessageBox.Show("had Lcompte makanch", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ///////////methode recherche linq//////////////
                var query = from g in ctx.GestionCompteSet
                            where g.Nom == bunifuMaterialTextbox4.Text && g.MotDePasse == bunifuMaterialTextbox3.Text
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

        }
    }
}
