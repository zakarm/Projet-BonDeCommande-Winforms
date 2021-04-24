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
    public partial class PvjForm : Form
    {
        public PvjForm()
        {
            InitializeComponent();
        }

        PVJ pn;

        private void load()
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumPvj.ValueMember = "IdPVJ";
                cb_NumPvj.DisplayMember = "NumPvj";
                cb_NumPvj.DataSource = ctx.PVJSet.ToList();


                cb_NumC.ValueMember = "IdConsultation";
                cb_NumC.DisplayMember = "ObjetConsultation";
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
            }

        }

        private void PvjForm_Load(object sender, EventArgs e)
        {
            load();
  
        }

        private bool check(DataGridView dv,PVJ pv, OnssaModelContainer4 ctx)
        {
            bool test = false;
            dv.CurrentCell = dv.Rows[0].Cells[0];

            try
            {

                    foreach (DataGridViewRow drm in dv.Rows)
                    {

                        if ((bool)drm.Cells["ck_btn"].FormattedValue.Equals(true))
                        {

                             
                              if(dv.Name.Equals("dgv_Fournisseur_Rep"))
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

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            //try
            //{


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    PVJ p = new PVJ();
                    Consultation c = new Consultation();

                    if (check(dgv_Commission, p, ctx) == true && check(dgv_Fournisseur_Rep, p, ctx))
                    {

                        ctx.Entry(p).State = System.Data.Entity.EntityState.Added;
                        c = ctx.ConsultationSet.Find(cb_NumC.SelectedValue);
                        p.NumPvj = cb_NumPvj.Text;
                        p.DateString = txtarea_DateString.Text;
                        p.DatePvj = date_Pvj.Value;
                        p.InfoConsultation = c;
                        ctx.PVJSet.Add(p);
                        ctx.SaveChanges();
                        cb_NumPvj.DataSource = ctx.PVJSet.ToList();
                        MessageBox.Show("Ajouté avec succès");
                    }
                    else
                    {
                        MessageBox.Show("sélectionner un fournisseur et une commission d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgv_Fournisseur_Rep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            //{

                        
            //    if (e.ColumnIndex == 4)
            //    {
            //        DataGridViewRow de = dgv_Fournisseur_Rep.Rows[int.Parse(e.RowIndex.ToString())]; 
            //        var query = from m in ctx.ModeleDevisSet join f in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals f.IdFournisseur
            //                    where m.InfoFournisseur.IdFournisseur == (int) de.Cells["Num"].Value
            //                    select new
            //                    {
            //                        Nom = f.Nom,
            //                        Devis = m.NumDevis,
            //                        Date = m.Date,

            //                    };
            //        dgv_Mdevis.DataSource = query.ToList();
            //    }

            //}
            
                
        }

        private void cb_NumC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    pn = ctx.PVJSet.Find(cb_NumPvj.SelectedValue);
                    cb_NumC.Text = pn.InfoConsultation.NumConsultation;
                    txtarea_DateString.Text = pn.DateString;
                    date_Pvj.Value = pn.DatePvj;

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
    }
}
