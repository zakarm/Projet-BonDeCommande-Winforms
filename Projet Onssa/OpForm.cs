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
    public partial class OpForm : Form
    {
        public OpForm()
        {
            InitializeComponent();
        }

        OP p;

        private void OpForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumOp.ValueMember = "IdOP";
                cb_NumOp.DisplayMember = "NumOP";
                cb_NumOp.DataSource = ctx.OPSet.ToList();

                cb_Oi.ValueMember = "IdOI";
                cb_Oi.DisplayMember = "NumOi";
                cb_Oi.DataSource = ctx.OISet.ToList();

            }
        }

        private void cb_Oi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    OP op = new OP();
                    OI oi = ctx.OISet.Find(cb_Oi.SelectedValue);
                    op.NumOP = cb_NumOp.Text;
                    op.DateOP = date_Op.Value;
                    op.InfoOI = oi;
                    ctx.OPSet.Add(op);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                    cb_NumOp.DataSource = ctx.OPSet.ToList();


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
                    ctx.OPSet.Remove(p);
                    ctx.SaveChanges();
                    MessageBox.Show("Supprimé avec succès");
                    cb_NumOp.DataSource = ctx.OPSet.ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_NumOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    p = ctx.OPSet.Find(cb_NumOp.SelectedValue);
                    cb_Oi.Text = p.InfoOI.NumOi;
                    date_Op.Value = p.DateOP;

                    var query = from op in ctx.OPSet
                                join oi in ctx.OISet on op.InfoOI.IdOI equals oi.IdOI
                                join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                select new
                                {
                                    OI = oi.NumOi,
                                    FE = fe.NumFe,
                                    BC = bc.NumBc,
                                    PVJ = pvj.IdPVJ,
                                };

                    dgv_Info.DataSource = query.ToList(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {

                    ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    OI oi = ctx.OISet.Find(cb_Oi.SelectedValue);
                    p.NumOP = cb_NumOp.Text;
                    p.DateOP = date_Op.Value;
                    p.InfoOI = oi;
                    ctx.SaveChanges();
                    MessageBox.Show("Modifié avec succès");
                    cb_NumOp.DataSource = ctx.OPSet.ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
