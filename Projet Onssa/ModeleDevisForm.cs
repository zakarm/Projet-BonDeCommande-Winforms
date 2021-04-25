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
        ModeleDevis md;
        private void ModeleDevisForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumMdevis.DisplayMember = "NumDevis";
                cb_NumMdevis.ValueMember = "IdModeleDevis";
                cb_NumMdevis.DataSource = ctx.ModeleDevisSet.ToList();

                cb_NumF.ValueMember = "IdFournisseur";
                cb_NumF.DisplayMember = "Nom";
                cb_NumF.DataSource = ctx.FournisseurSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            dgv_Produits.CurrentCell = dgv_Produits.Rows[0].Cells[0];
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                ModeleDevis m = new ModeleDevis();
                Fournisseur f = ctx.FournisseurSet.Find(cb_NumF.SelectedValue);
                Produit p ;

                m.NumDevis = cb_NumMdevis.Text;
                m.InfoFournisseur = f;
                m.Date = date_MDevis.Value;

                foreach (DataGridViewRow dr in dgv_Produits.Rows)
                {
                    if (dr.Cells[1].Value != null)
                    {
                        p = new Produit();
                        p.Designation = dr.Cells[0].Value.ToString();
                        p.Unite = dr.Cells[1].Value.ToString();
                        p.Quantite = int.Parse(dr.Cells[2].Value.ToString());
                        p.Prix_Unitaire = int.Parse(dr.Cells[3].Value.ToString());
                        m.ListProduit.Add(p);
                    }

                }

                ctx.ModeleDevisSet.Add(m);
                ctx.SaveChanges();
                cb_NumMdevis.DataSource = ctx.ModeleDevisSet.ToList();
                dgv_Produits.Rows.Clear();
                MessageBox.Show("Ajouté avec succès");
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ctx.Entry(md).State = System.Data.Entity.EntityState.Deleted;
                    ctx.ModeleDevisSet.Remove(md);
                    cb_NumMdevis.DataSource = ctx.PVJSet.ToList();
                    ctx.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_NumMdevis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_Produits.Rows.Clear();
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    md = ctx.ModeleDevisSet.Find(cb_NumMdevis.SelectedValue);
                    cb_NumF.Text = md.InfoFournisseur.Nom;
                    date_MDevis.Value = md.Date;

                    foreach (Produit m in md.ListProduit)
                    {

                        dgv_Produits.Rows.Add(m.Designation, m.Unite, m.Quantite, m.Prix_Unitaire);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            dgv_Produits.CurrentCell = dgv_Produits.Rows[0].Cells[0];
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                ctx.Entry(md).State = System.Data.Entity.EntityState.Modified;
                Fournisseur f = ctx.FournisseurSet.Find(cb_NumF.SelectedValue);
                Produit p;

                md.NumDevis = cb_NumMdevis.Text;
                md.InfoFournisseur = f;
                md.Date = date_MDevis.Value;
                md.ListProduit.Clear();

                foreach (DataGridViewRow dr in dgv_Produits.Rows)
                {
                    if (dr.Cells[1].Value != null)
                    {
                        p = new Produit();
                        p.Designation = dr.Cells[0].Value.ToString();
                        p.Unite = dr.Cells[1].Value.ToString();
                        p.Quantite = int.Parse(dr.Cells[2].Value.ToString());
                        p.Prix_Unitaire = int.Parse(dr.Cells[3].Value.ToString());
                        md.ListProduit.Add(p);
                    }

                }

                ctx.SaveChanges();
                cb_NumMdevis.DataSource = ctx.ModeleDevisSet.ToList();
                dgv_Produits.Rows.Clear();
                MessageBox.Show("Modifier avec succès");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(dgv_Produits.Rows.Count > 2)
                {
                    dgv_Produits.Rows.Remove(dgv_Produits.CurrentRow);
                    MessageBox.Show("Supression du Produit");
                }
                else
                {
                    MessageBox.Show("Modèle de devis sans produit !");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
