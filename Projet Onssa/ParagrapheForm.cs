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
    public partial class ParagrapheForm : Form
    {
        public ParagrapheForm()
        {
            InitializeComponent();
        }

        private void ParagrapheForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Num.DisplayMember = "NumPar";
                cb_Num.ValueMember = "NumPar";
                cb_Num.DataSource = ctx.ParagrapheSet.ToList();
            }
        }
        Paragraphe p;
        private void cb_Num_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                p = ctx.ParagrapheSet.Find(cb_Num.SelectedValue);
                txtarea_desc.Text = p.DescriptionPar;
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    Paragraphe Op = new Paragraphe();
                    Op.NumPar = int.Parse(cb_Num.Text);
                    Op.DescriptionPar = txtarea_desc.Text;
                    ctx.ParagrapheSet.Add(Op);
                    ctx.SaveChanges();
                    MessageBox.Show("ok");
                    cb_Num.DataSource = ctx.ParagrapheSet.ToList();

                }
                catch(Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    p.DescriptionPar = txtarea_desc.Text;
                    ctx.SaveChanges();
                    MessageBox.Show("ok");
                    cb_Num.DataSource = ctx.ParagrapheSet.ToList();
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    ctx.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                    MessageBox.Show("ok");
                    cb_Num.DataSource = ctx.ParagrapheSet.ToList();

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }
    }
}
