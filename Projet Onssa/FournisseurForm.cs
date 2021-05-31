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
    public partial class FournisseurForm : Form
    {
        Fournisseur f;
        public FournisseurForm()
        {
            InitializeComponent();
        }

        private void FournisseurForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Nom.DisplayMember = "Nom";
                cb_Nom.ValueMember = "IdFournisseur";
                cb_Nom.DataSource = ctx.FournisseurSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                        Fournisseur of = new Fournisseur();

                        of.Nom = cb_Nom.Text;
                        of.Adresse = txt_Adresse.Text;
                        of.RC_n = int.Parse(txt_Rcn.Text);
                        of.Patente_n = txt_Patenten.Text;
                        of.IF_n = int.Parse(txt_Ifn.Text);
                        of.CNSS_n = int.Parse(txt_cnss.Text);
                        of.Compte_bancaire_n = txt_CmptBancaire.Text;
                        of.ICE = txt_Ice.Text;
                        of.Ville = txt_Ville.Text;
                        of.Banque = txt_Banque.Text;

                        ctx.FournisseurSet.Add(of);
                        ctx.SaveChanges();
                         DeclarationGlobale.vider(this);
                        cb_Nom.DataSource = ctx.FournisseurSet.ToList();

                        MessageBox.Show("Ajouté avec succès");
                }
                    
            }
            catch (FormatException)
            {
                MessageBox.Show("Format text non valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
                
            }
        }

        

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        f.Nom = cb_Nom.Text;
                        f.Adresse = txt_Adresse.Text;
                        f.RC_n = int.Parse(txt_Rcn.Text);
                        f.Patente_n = txt_Patenten.Text;
                        f.IF_n = int.Parse(txt_Ifn.Text);
                        f.CNSS_n = int.Parse(txt_cnss.Text);
                        f.Compte_bancaire_n = txt_CmptBancaire.Text;
                        f.ICE = txt_Ice.Text;
                        f.Ville = txt_Ville.Text;
                        f.Banque = txt_Banque.Text;

                        ctx.Entry(f).State = System.Data.Entity.EntityState.Modified;

                        ctx.SaveChanges();
                        DeclarationGlobale.vider(this);

                        cb_Nom.DataSource = ctx.FournisseurSet.ToList();

                        MessageBox.Show("Modifier avec succès");
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
            }

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(f).State = System.Data.Entity.EntityState.Deleted;
                        ctx.FournisseurSet.Remove(f);
                        ctx.SaveChanges();

                        cb_Nom.DataSource = ctx.FournisseurSet.ToList();

                        MessageBox.Show("Supprimer avec succès");
                        DeclarationGlobale.vider(this);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException )
                    {
                        MessageBox.Show("le Fournisseur est déja utilisé dans un procès verbal de jugement ou dans un consultation");
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
            }

        }

        private void cb_Nom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    f = ctx.FournisseurSet.Find(cb_Nom.SelectedValue);

                    txt_Adresse.Text = f.Adresse;
                    txt_Rcn.Text = f.RC_n.ToString();
                    txt_Patenten.Text = f.Patente_n.ToString();
                    txt_Ifn.Text = f.IF_n.ToString();
                    txt_cnss.Text = f.CNSS_n.ToString();
                    txt_CmptBancaire.Text = f.Compte_bancaire_n.ToString();
                    txt_Ice.Text = f.ICE.ToString();
                    txt_Ville.Text = f.Ville.ToString();
                    txt_Banque.Text = f.Banque.ToString();
                }
            
        }

        private void cb_Nom_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_Adresse_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_Patenten_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_CmptBancaire_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_Ice_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_Ville_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_Banque_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
