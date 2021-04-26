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

        private void btn_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void PvrForm_Load(object sender, EventArgs e)
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

        private void cb_Oi_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Commission.Rows.Clear();
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from oi in ctx.OISet
                            join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                            join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                            join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
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
    }
}
