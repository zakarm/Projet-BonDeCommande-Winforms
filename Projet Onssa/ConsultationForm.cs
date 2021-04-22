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

namespace Projet_Onssa
{
    public partial class ConsultationForm : Form
    {
        public ConsultationForm()
        {
            InitializeComponent();
        }

        bool test = false;

        private void ConsultationForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
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
                DataGridViewCheckBoxColumn ck_btn = new DataGridViewCheckBoxColumn();
                ck_btn.HeaderText = "Select";
                ck_btn.Name = "ck_btn";
                ck_btn.ValueType = typeof(bool);
                dgv_Fournisseur.Columns.Add(ck_btn);
                
            }

            
        }
        private bool check (Consultation con, OnssaModelContainer4 ctx)
        {
            

            foreach (DataGridViewRow drm in dgv_Fournisseur.Rows)
            {
                if (bool.Parse(drm.Cells["ck_btn"].FormattedValue.ToString()) == true)
                {
                        
                        try
                        {
                            test = true;      
                            Fournisseur fr = ctx.FournisseurSet.Find(int.Parse(drm.Cells["Num"].Value.ToString()));
                            con.ListFournisseur.Add(fr);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                   

                }
                drm.Cells["ck_btn"].Value = false;
            }

            return test;
        }

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
                        ctx.ConsultationSet.Add(con);
                        ctx.SaveChanges();
                        cb_Num.DataSource = ctx.ConsultationSet.ToList();
                        MessageBox.Show("Ajout De Consultation");
                    }
                    else
                    {
                        MessageBox.Show("Selectione un fournisseur d'abord", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
             
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
                
        }

        public void recherche()
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                
                Consultation c = ctx.ConsultationSet.Find(cb_Num.SelectedValue);
                txtarea_Objet.Text = c.ObjetConsultation;
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

        private void cb_Num_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherche();
        }
    }
}
