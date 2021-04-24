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
    public partial class ModeleDevisForm : Form
    {
        public ModeleDevisForm()
        {
            InitializeComponent();
        }

        private void ModeleDevisForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumMdevis.DisplayMember = "NumDevis";
                cb_NumMdevis.ValueMember = "IdModeleDevis";
                cb_NumMdevis.DataSource = ctx.ModeleDevisSet.ToList();

                cb_NumF.ValueMember = "IdFournisseur";
                cb_NumF.DisplayMember = "Nom";
                cb_NumF.DataSource = ctx.ModeleDevisSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

        }
    }
}
