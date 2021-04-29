﻿using System;
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
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    p.ListCommission.Clear();

                    if (check(p, ctx) == true)
                    {

                        OI oi = ctx.OISet.Find(cb_Oi.SelectedValue);
                        p.DatePVR = data_Pvr.Value;
                        p.DateString = txt_dateString.Text;
                        p.InfoOI = oi;
                        ctx.SaveChanges();
                        cb_NumPvr.DataSource = ctx.PVRSet.ToList();

                        MessageBox.Show("Modifié avec succès");
                    }
                    else
                    {
                        MessageBox.Show("sélectionner une commissionr d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    cb_NumPvr.DisplayMember = "IdPvr";
                    cb_NumPvr.ValueMember = "IdPvr";
                    cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Oi_SelectedIndexChanged(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_NumPvr_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    p = ctx.PVRSet.Find(cb_NumPvr.SelectedValue);
                    txt_dateString.Text = p.DateString;
                    data_Pvr.Value = p.DatePVR;
                    cb_Oi.SelectedValue = p.InfoOI.IdOI;
                    cb_NumPvr.SelectedValue = p.IdPVR;

                    foreach (DataGridViewRow drm in dgv_Commission.Rows)
                    {
                        drm.Cells["ck_btn"].Value = false;
                        foreach (Commission m in p.ListCommission)
                        {
                            if (int.Parse(drm.Cells["Num"].Value.ToString()) == m.IdCommission)
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

        private bool check(PVR pvr, OnssaModelContainer4 ctx)
        {
            bool test = false;
            dgv_Commission.CurrentCell = dgv_Commission.Rows[0].Cells[0];

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
                        pvr.DatePVR = data_Pvr.Value;
                        pvr.DateString = txt_dateString.Text;
                        pvr.InfoOI = oi;
                        ctx.PVRSet.Add(pvr);
                        ctx.SaveChanges();
                        cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                        MessageBox.Show("Ajouté avec succès");

                    }
                    else
                    {
                        MessageBox.Show("sélectionner une commission d'abord !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ctx.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    ctx.PVRSet.Remove(p);
                    ctx.SaveChanges();
                    cb_NumPvr.DataSource = ctx.PVRSet.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}