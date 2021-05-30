using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Bunifu.Framework;

namespace Projet_Onssa
{
    public partial class ConsultationForm : Form
    {
        public ConsultationForm()
        {
            InitializeComponent();
        }
        
        Consultation c;

        //---------------------------------------------Load-Form--------------------------------------
        private void ConsultationForm_Load(object sender, EventArgs e)
        {

           

           
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Num.DisplayMember = "NumConsultation";
                cb_Num.ValueMember = "IdConsultation";
                cb_Num.DataSource = ctx.ConsultationSet.ToList();

                var query = from f in ctx.FournisseurSet
                            select new
                            {
                                Num = f.IdFournisseur,
                                Nom = f.Nom,
                                Adresse = f.Adresse,
                                Ville = f.Ville,

                            };
                dgv_Fournisseur.DataSource = query.ToList();
                DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn();
                ck.ValueType = typeof(bool);
                ck.HeaderText = "Select";
                ck.Name = "ck_btn";
                dgv_Fournisseur.Columns.Add(ck);

                DeclarationGlobale.vider(this);

            }

        }

        //-------------------------------Function-Ajout-Fournniseur-Dans-La-List---------------------
        private bool check (Consultation con, OnssaModelContainer4 ctx)
        {
            bool test = false;


            dgv_Fournisseur.CurrentCell = dgv_Fournisseur.Rows[0].Cells["Num"];
            foreach (DataGridViewRow drm in dgv_Fournisseur.Rows)
            {

                if ((bool)drm.Cells["ck_btn"].FormattedValue.Equals(true))
                {
                    try
                    {
                        test = true;

                        Fournisseur fr = ctx.FournisseurSet.Find(int.Parse(drm.Cells["Num"].FormattedValue.ToString()));
                        con.ListFournisseur.Add(fr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               this.dgv_Fournisseur.ClearSelection();
                drm.Cells["ck_btn"].Value = false;

            }
            
            return test;
        }

        //---------------------------------------------Ajouter----------------------------------------
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

            
            try
            { 
                
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    Consultation con = new Consultation();
                    
                    if (check(con, ctx) == true)
                    {
                        con.NumConsultation = cb_Num.Text;
                        con.ObjetConsultation = txtarea_Objet.Text;
                        con.NumEnvoi = int.Parse( txt_numenvoi.Text);
                        con.DateLettre = date_envoi.Value;
                        con.DateDelai = date_delai.Value;
                        ctx.Entry(con).State = System.Data.Entity.EntityState.Added;
                        ctx.ConsultationSet.Add(con);

                        ctx.SaveChanges();
                        cb_Num.DataSource = ctx.ConsultationSet.ToList();
                        MessageBox.Show("Ajouté avec succès");
                        DeclarationGlobale.vider(this);
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Sélectionner un fournisseur d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            catch(FormatException)
            {
                MessageBox.Show("Format text non valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        

       //---------------------------------------------Supprimer----------------------------------------
        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(c).State = System.Data.Entity.EntityState.Deleted;
                        ctx.ConsultationSet.Remove(c);
                        ctx.SaveChanges();
                        cb_Num.DataSource = ctx.ConsultationSet.ToList();
                        MessageBox.Show("Supprimé avec succès");
                        DeclarationGlobale.vider(this);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("consultation déja utilisé dans un procès verbal de jugment ou dans un modele de devis");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                DeclarationGlobale.vider(this);
            }
            
        }
        

        //---------------------------------------------Modifier----------------------------------------
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                    {
                        ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        c.ListFournisseur.Clear();
                        

                        if (check(c, ctx) == true)
                        {
                            
                            c.NumConsultation = cb_Num.Text;
                            c.ObjetConsultation = txtarea_Objet.Text;
                            c.NumEnvoi = int.Parse(txt_numenvoi.Text); 
                            c.DateLettre = date_envoi.Value;
                            c.DateDelai = date_delai.Value;

                            ctx.SaveChanges();
                            cb_Num.DataSource = ctx.ConsultationSet.ToList();

                            MessageBox.Show("Modifié avec succès");
                            DeclarationGlobale.vider(this);
                        }
                        else
                        {
                            MessageBox.Show("sélectionner un fournisseur d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //---------------------------------------------Recherche-with-Combobox--------------------------

        private void cb_Num_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    c = ctx.ConsultationSet.Find(cb_Num.SelectedValue);
                    txtarea_Objet.Text = c.ObjetConsultation;
                    txt_numenvoi.Text = c.NumEnvoi.ToString();
                    date_envoi.Value = c.DateLettre;
                    date_delai.Value = c.DateDelai;
                    foreach (DataGridViewRow drm in dgv_Fournisseur.Rows)
                    {
                        drm.Cells["ck_btn"].Value = false;
                        foreach (Fournisseur f in c.ListFournisseur)
                        {
                            if (int.Parse(drm.Cells["Num"].Value.ToString()) == f.IdFournisseur)
                            {
                                drm.Cells["ck_btn"].Value = true;

                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
