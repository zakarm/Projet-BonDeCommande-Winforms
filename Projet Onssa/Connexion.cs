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

namespace Projet_Onssa
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btn_Cnx_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
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
                    Connexion c = new Connexion();c.Close();
                }
                else
                 MessageBox.Show("Compte Introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
