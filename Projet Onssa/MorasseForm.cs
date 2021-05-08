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
    public partial class MorasseForm : Form
    {
        public MorasseForm()
        {
            InitializeComponent();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    Morasse m = new Morasse();
                    Ligne l = ctx.LigneSet.Find(cb_Ligne.SelectedValue);
                    m.Budget = txt_budget.Text;
                    m.Exercice = txt_exercice.Text;
                    m.Ligne = l;
                    m.CodeMorasse = int.Parse(l.CodeLigne.ToString() + l.InfoLrg.CodeLrg.ToString());
                    m.Description = txt_description.Text;
                    ctx.MorasseSet.Add(m);
                    ctx.SaveChanges();
                    MessageBox.Show("Ok");
                    cb_Morasse.DataSource = ctx.MorasseSet.ToList();

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        Morasse om;
        private void cb_Morasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    om = ctx.MorasseSet.Find(cb_Morasse.SelectedValue);

                    cb_Ligne.SelectedValue = int.Parse(om.Ligne.CodeLigne.ToString());
                    txt_budget.Text = om.Budget.ToString();
                    txt_exercice.Text = om.Exercice.ToString();

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        private void MorasseForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    cb_Morasse.DisplayMember = "CodeMorasse";
                    cb_Morasse.ValueMember = "CodeMorasse";
                    cb_Morasse.DataSource = ctx.MorasseSet.ToList();

                    cb_Ligne.DisplayMember = "CodeLigne";
                    cb_Ligne.ValueMember = "CodeLigne";
                    cb_Ligne.DataSource = ctx.LigneSet.ToList();
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        Ligne ol;

        private void cb_Ligne_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    ol = ctx.LigneSet.Find(cb_Ligne.SelectedValue);
                    txt_description.Text = ol.DescriptionLigne.ToString();
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
                    ctx.Entry(om).State = System.Data.Entity.EntityState.Deleted;

                    ctx.MorasseSet.Remove(om);
                    ctx.SaveChanges();
                    MessageBox.Show("Supp ok");
                    cb_Morasse.DataSource = ctx.MorasseSet.ToList();
                }
                catch (Exception o)
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
                    ctx.Entry(om).State = System.Data.Entity.EntityState.Modified;
                    om.Budget = txt_budget.Text;
                    om.Exercice = txt_exercice.Text;
                    om.Description = txt_description.Text;
                    ctx.SaveChanges();
                    MessageBox.Show("Modi Ok");
                    cb_Morasse.DataSource = ctx.MorasseSet.ToList();

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }
    }
}
