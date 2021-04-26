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

        //public void loadCombo(ComboBox c,string key,string value,OnssaModelContainer4 ctx,)
        //{
            
        //    c.ValueMember = key;
        //    c.DisplayMember = value;
        //    c.DataSource = ctx.ToList();
        //}

        private void OpForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumOp.ValueMember = "IdOP";
                cb_NumOp.DisplayMember = "NumOP";
                cb_NumOp.DataSource = ctx.OPSet.ToList();
            }
        }
    }
}
