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
    public partial class PvrForm : Form
    {
        public PvrForm()
        {
            InitializeComponent();
        }

        PVR p;

        private void btn_Modifier_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                        p.ListCommission.Clear();

                        if (check(p, ctx) == true)
                        {

                            OI oi = ctx.OISet.Find(cb_Oi.SelectedValue);
                            p.NumPvr = cb_NumPvr.Text;
                            p.DatePVR = data_Pvr.Value;
                            p.InfoOI = oi;
                            ctx.SaveChanges();
                            

                            MessageBox.Show("Modifié avec succès");
                            DeclarationGlobale.vider(this);
                            cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                        }
                        else
                        {
                            MessageBox.Show("sélectionner une commissionr d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Cette OI est déjà utilisée dans un autre Pvr!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }else DeclarationGlobale.vider(this);

        }

        private void PvrForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    cb_Oi.DisplayMember = "NumOi";
                    cb_Oi.ValueMember = "IdOI";
                    cb_Oi.DataSource = ctx.OISet.ToList();

                    cb_NumPvr.DisplayMember = "NumPvr";
                    cb_NumPvr.ValueMember = "IdPvr";
                    cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

       

        private bool check(PVR pvr, OnssaModelContainer4 ctx)
        {
            bool test = false;
            dgv_Commission.CurrentCell = dgv_Commission.Rows[0].Cells["Num"];

            foreach (DataGridViewRow drm in dgv_Commission.Rows)
            {

                if ((bool)drm.Cells["ck_btn"].FormattedValue.Equals(true))
                {
                    try
                    {
                        test = true;

                        Commission co = ctx.CommissionSet.Find(int.Parse(drm.Cells["Num"].FormattedValue.ToString()));
                        pvr.ListCommission.Add(co);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                dgv_Commission.ClearSelection();
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
                    PVR pvr = new PVR();

                    if (check(pvr, ctx) == true)
                    {
                        OI oi = ctx.OISet.Find(cb_Oi.SelectedValue);
                        pvr.NumPvr = cb_NumPvr.Text;
                        pvr.DatePVR = data_Pvr.Value;
                        pvr.InfoOI = oi;
                        ctx.PVRSet.Add(pvr);
                        ctx.SaveChanges();
                        cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                        MessageBox.Show("Ajouté avec succès");

                    }
                    else
                    {
                        MessageBox.Show("Sélectionner une commission d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                DeclarationGlobale.vider(this);

            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("lordre d'imputation est déjà utilisée dans un autre procès verbal de reception!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Format text non valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        ctx.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                        ctx.PVRSet.Remove(p);
                        ctx.SaveChanges();
                        MessageBox.Show("Supprimer avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Procès verbal de reception déja Utilisé ");
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
            }
        }

        private void cb_NumPvr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    p = ctx.PVRSet.Find(cb_NumPvr.SelectedValue);
                    data_Pvr.Value = p.DatePVR;
                    cb_Oi.Text = p.InfoOI.NumOi.ToString();
                    cb_NumPvr.SelectedValue = p.IdPVR;
                    


                    foreach (DataGridViewRow drm in dgv_Commission.Rows)
                    {
                        drm.Cells["ck_btn"].Value = false;
                        foreach (Commission m in p.ListCommission)
                        {
                            if ( int.Parse(drm.Cells["Num"].Value.ToString()) == m.IdCommission)
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

        private void cb_Oi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgv_Commission.Rows.Clear();

                if (dgv_Commission.Columns.Count <= 5)
                {
                    DataGridViewCheckBoxColumn ck2 = new DataGridViewCheckBoxColumn();
                    ck2.ValueType = typeof(bool);
                    ck2.HeaderText = "Select";
                    ck2.Name = "ck_btn";
                    dgv_Commission.Columns.Add(ck2);
                }


                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from oi in ctx.OISet
                                join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                where oi.IdOI == (int)cb_Oi.SelectedValue
                                select pvj.IdPVJ;

                    int idpvj = int.Parse(query.FirstOrDefault().ToString());

                    foreach (PVJ p in ctx.PVJSet)
                    {
                        if (p.IdPVJ == idpvj)
                        {
                            foreach (Commission c in p.ListCommissions)
                            {
                                dgv_Commission.Rows.Add(c.IdCommission, c.Nom, c.Prenom, c.Affectation, c.Fonction);
                            }
                            break;
                        }

                    }

                }



        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void txt_Destination_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
