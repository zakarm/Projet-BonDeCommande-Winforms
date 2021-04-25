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
    public partial class BcForm : Form
    {
        public BcForm()
        {
            InitializeComponent();
        }

        private void BcForm_Load(object sender, EventArgs e)
        {
            
        }

        private void viderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.vider(this);
        }

        private void cb_NumBc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumBc.DisplayMember = "IdBC";
                cb_NumBc.ValueMember = "NumBc";
                cb_NumBc.DataSource = ctx.BCSet.ToList();

                cb_Morasse.ValueMember = "Code";
                cb_Morasse.DisplayMember = "Code";
                cb_Morasse.DataSource = ctx.MorasseSet.ToList();

                cb_Pvj.ValueMember = "IdPVJ";
                cb_Pvj.DisplayMember = "NumPvj";
                cb_Pvj.DataSource = ctx.PVJSet.ToList();

            }
        }

        private void cb_Pvj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
