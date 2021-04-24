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
    public partial class CommissionForm : Form
    {
        Commission c;
        public CommissionForm()
        {
            InitializeComponent();
        }

        private void remplir_DGV()
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var q =
                   from c in ctx.CommissionSet
                   select new
                   {
                       Num = c.IdCommission,
                       Nom = c.Nom,
                       Prenom = c.Prenom,
                       Affectation = c.Affectation,
                       fonctio = c.Fonction,
                   };

                dgv_Commission.DataSource = q.ToList();
            }
            
        }
        private void CommissionForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Nom.DisplayMember = "Nom";
                cb_Nom.ValueMember = "IdCommission";
                cb_Nom.DataSource = ctx.CommissionSet.ToList();
            }
            remplir_DGV();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void cb_Nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                c = ctx.CommissionSet.Find(cb_Nom.SelectedValue);

                txt_Prenom.Text = c.Prenom;
                txt_Fonction.Text = c.Fonction;
                txt_Affectation.Text = c.Affectation;
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    Commission oc = new Commission();

                    oc.Nom = cb_Nom.Text;
                    oc.Prenom = txt_Prenom.Text;
                    oc.Affectation = txt_Affectation.Text;
                    oc.Fonction = txt_Fonction.Text;
                    
                    ctx.CommissionSet.Add(oc);
                    ctx.SaveChanges();

                    cb_Nom.DataSource = ctx.CommissionSet.ToList();

                    MessageBox.Show("Ajouté avec succès");
                }
                remplir_DGV();
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ctx.Entry(c).State = System.Data.Entity.EntityState.Deleted;
                    ctx.CommissionSet.Remove(c);
                    ctx.SaveChanges();

                    cb_Nom.DataSource = ctx.CommissionSet.ToList();
                }

            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
            remplir_DGV();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {

                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    c.Nom = cb_Nom.Text;
                    c.Prenom = txt_Prenom.Text;
                    c.Affectation = txt_Affectation.Text;
                    c.Fonction = txt_Fonction.Text;
                    
                    ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;

                    ctx.SaveChanges();

                    cb_Nom.DataSource = ctx.CommissionSet.ToList();

                    MessageBox.Show("Modifier avec succès");
                }
            }

            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
            remplir_DGV();
        }
    }
}
