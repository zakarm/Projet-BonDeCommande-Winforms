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
using System.Data.Sql;
using System.Linq.Expressions;
using System.Data.SqlTypes;

namespace Projet_Onssa
{
    public partial class PvjForm : Form
    {
        public PvjForm()
        {
            InitializeComponent();

        }

        PVJ pn;

        //---------------------------------------------Load-form----------------------------------------
        
        private void PvjForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumPvj.ValueMember = "IdPVJ";
                cb_NumPvj.DisplayMember = "NumPvj";
                cb_NumPvj.DataSource = ctx.PVJSet.ToList();


                cb_NumC.ValueMember = "IdConsultation";
                cb_NumC.DisplayMember = "NumConsultation";
                cb_NumC.DataSource = ctx.ConsultationSet.ToList();
                //--------------------------------------------linq to Commission--------------------------------------------

                var query = from co in ctx.CommissionSet
                            select new
                            {
                                Num = co.IdCommission,
                                Nom = co.Nom,
                                Prenom = co.Prenom,
                            };
                dgv_Commission.DataSource = query.ToList();

                //-----checkbox---datagrid1

                DataGridViewCheckBoxColumn ck = new DataGridViewCheckBoxColumn();
                ck.ValueType = typeof(bool);
                ck.HeaderText = "Select";
                ck.Name = "ck_btn";
                dgv_Commission.Columns.Add(ck);

                //--------------------------------------------linq to Fournisseur --------------------------------------------

                var queryy = from f in ctx.FournisseurSet
                             select new
                             {
                                 Num = f.IdFournisseur,
                                 Nom = f.Nom,
                                 Adresse = f.Adresse,
                                 Ville = f.Ville,

                             };
                dgv_Fournisseur_Rep.DataSource = queryy.ToList();

                //-----checkbox---datagrid2

                DataGridViewCheckBoxColumn ck2 = new DataGridViewCheckBoxColumn();
                ck2.ValueType = typeof(bool);
                ck2.HeaderText = "Select";
                ck2.Name = "ck_btn";
                dgv_Fournisseur_Rep.Columns.Add(ck2);
                DeclarationGlobale.vider(this);

            }
        }

        private bool check(DataGridView dv, PVJ pv, OnssaModelContainer4 ctx)
        {
            bool test = false;
            dv.CurrentCell = dv.Rows[0].Cells["Num"];

            try
            {

                foreach (DataGridViewRow drm in dv.Rows)
                {

                    if ((bool)drm.Cells["ck_btn"].FormattedValue.Equals(true))
                    {


                        if (dv.Name.Equals("dgv_Fournisseur_Rep"))
                        {
                            test = true;
                            Fournisseur fr = ctx.FournisseurSet.Find(int.Parse(drm.Cells["Num"].FormattedValue.ToString()));
                            pv.ListFournisseursRepondu.Add(fr);

                        }
                        else
                        {
                            test = true;
                            Commission cm = ctx.CommissionSet.Find(int.Parse(drm.Cells["Num"].FormattedValue.ToString()));
                            pv.ListCommissions.Add(cm);
                        }


                    }
                    drm.Cells["ck_btn"].Value = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return test;
        }


        //---------------------------------------------Ajouter-----------------------------------------
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    PVJ pv = new PVJ();
                    Consultation c;
                    Fournisseur f;
                    NumToString tr = new NumToString();

                   

                    if (check(dgv_Commission, pv, ctx) == true && check(dgv_Fournisseur_Rep, pv, ctx) == true)
                    {
                        c = ctx.ConsultationSet.Find(cb_NumC.SelectedValue);


                        f = ctx.FournisseurSet.Find(cb_fchoisie.SelectedValue);

                        pv.NumPvj = cb_NumPvj.Text;
                        pv.InfoConsultation = c;
                        pv.DatePvj = date_Pvj.Value;
                        pv.InfoFournisseur = f;

                        ctx.PVJSet.Add(pv);

                        ctx.SaveChanges();
                        cb_NumPvj.DataSource = ctx.PVJSet.ToList();
                        MessageBox.Show("Ajouté avec succès");
                    }
                    else
                    {
                        MessageBox.Show("sélectionner un fournisseur et une commission d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DeclarationGlobale.vider(this);


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format text non valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch (System.Data.Entity.Infrastructure.DbUpdateException )
            {
                MessageBox.Show("Cette consultation est déjà utilisée dans un autre procès verbale de jugement !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeclarationGlobale.vider(this);
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
                        ctx.Entry(pn).State = System.Data.Entity.EntityState.Deleted;
                        ctx.PVJSet.Remove(pn);
                        ctx.SaveChanges();
                        MessageBox.Show("Supprimer avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumPvj.DataSource = ctx.PVJSet.ToList();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException )
                    {
                        MessageBox.Show("le procès verbal de jugement est déja Utilisé ");
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
                DeclarationGlobale.vider(this);
            }
        }

        //---------------------------------------------Modifier----------------------------------------
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(pn).State = System.Data.Entity.EntityState.Modified;
                        Consultation c = c = ctx.ConsultationSet.Find(cb_NumC.SelectedValue);
                        Fournisseur f;
                        ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        pn.ListFournisseursRepondu.Clear();
                        pn.ListCommissions.Clear();

                        if (check(dgv_Commission, pn, ctx) == true && check(dgv_Fournisseur_Rep, pn, ctx) == true && cb_fchoisie.Text != "")
                        {


                            f = ctx.FournisseurSet.Find(cb_fchoisie.SelectedValue);
                            pn.NumPvj = cb_NumPvj.Text;
                            pn.InfoConsultation = c;
                            pn.DatePvj = date_Pvj.Value;
                            pn.InfoFournisseur = f;

                            ctx.SaveChanges();

                            cb_NumPvj.DataSource = ctx.PVJSet.ToList();
                            MessageBox.Show("Modifié avec succès");


                        }
                        else
                        {
                            MessageBox.Show("sélectionner un fournisseur et une commission d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        DeclarationGlobale.vider(this);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Format text non valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Cette consultation est déjà utilisée dans un autre procès verbale de jugement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
            }
        }
       
        //-------------------------------------Load-Combo-From-gridview-to-Combo---------------------
        
        //---------------------------------------------Viderr----------------------------------------
        private void viderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DeclarationGlobale.vider(this);
        }

        //---------------------------------------------Recherche-with-Combo----------------------------
        
        private void cb_NumPvj_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    pn = ctx.PVJSet.Find(cb_NumPvj.SelectedValue);
                    cb_NumC.Text = pn.InfoConsultation.NumConsultation;
                    date_Pvj.Value = pn.DatePvj;
                    cb_fchoisie.Text = pn.InfoFournisseur.Nom;

                    foreach (DataGridViewRow drm in dgv_Commission.Rows)
                    {
                        drm.Cells["ck_btn"].Value = false;
                        foreach (Commission m in pn.ListCommissions)
                        {
                            if (int.Parse(drm.Cells["Num"].Value.ToString()) == m.IdCommission)
                            {
                                drm.Cells["ck_btn"].Value = true;

                            }
                        }
                    }

                    foreach (DataGridViewRow drm in dgv_Fournisseur_Rep.Rows)
                    {
                        drm.Cells["ck_btn"].Value = false;
                        foreach (Fournisseur f in pn.ListFournisseursRepondu)
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

        private void cb_fchoisie_Click_1(object sender, EventArgs e)
        {
            //dgv_Fournisseur_Rep.CurrentCell = dgv_Fournisseur_Rep.Rows[0].Cells[0];
            try
            {
                cb_fchoisie.DataSource = null;
                cb_fchoisie.Text = "";
                Dictionary<int, string> test = new Dictionary<int, string>();

                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    foreach (DataGridViewRow dr in dgv_Fournisseur_Rep.Rows)
                    {
                        if ((bool)dr.Cells["ck_btn"].FormattedValue.Equals(true))
                        {
                            test.Add(int.Parse(dr.Cells["Num"].FormattedValue.ToString()), dr.Cells["Nom"].FormattedValue.ToString());
                        }
                    }

                    cb_fchoisie.ValueMember = "Key";
                    cb_fchoisie.DisplayMember = "Value";
                    cb_fchoisie.DataSource = new BindingSource(test, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_fchoisie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_NumC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_fchoisie.Text = "";
        }
    }
}