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
    public partial class LigneForm : Form
    {
        public LigneForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LigneForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_codeligne.DisplayMember = "CodeLigne";
                cb_codeligne.ValueMember = "CodeLigne";
                cb_codeligne.DataSource = ctx.LigneSet.ToList();

                cb_Numlrg.DisplayMember = "CodeLrg";
                cb_Numlrg.ValueMember = "CodeLrg";
                cb_Numlrg.DataSource = ctx.LrgSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    Lrg l = ctx.LrgSet.Find(cb_Numlrg.SelectedValue);
                    Ligne ol = new Ligne();
                    ol.CodeLigne =int.Parse(cb_codeligne.Text.ToString());
                    ol.DescriptionLigne = txtarea_desc.Text;
                    ol.InfoLrg = l;

                    ctx.LigneSet.Add(ol);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                    DeclarationGlobale.vider(this);
                    cb_codeligne.DataSource = ctx.LigneSet.ToList();

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
        }

        Ligne oll;
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(oll).State = System.Data.Entity.EntityState.Modified;
                        oll.DescriptionLigne = txtarea_desc.Text;
                        oll.InfoLrg = ctx.LrgSet.Find(cb_Numlrg.SelectedValue);

                        ctx.SaveChanges();
                        MessageBox.Show("Modifier avec succès");
                        DeclarationGlobale.vider(this);
                        cb_codeligne.DataSource = ctx.LigneSet.ToList();
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
            }
        }

        private void cb_codeligne_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    oll = ctx.LigneSet.Find(cb_codeligne.SelectedValue);

                    cb_Numlrg.Text = oll.InfoLrg.CodeLrg.ToString();
                    txtarea_desc.Text = oll.DescriptionLigne;

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
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
                        ctx.Entry(oll).State = System.Data.Entity.EntityState.Deleted;

                        ctx.LigneSet.Remove(oll);

                        ctx.SaveChanges();

                        MessageBox.Show("Supprimer avec succès");
                        DeclarationGlobale.vider(this);
                        cb_codeligne.DataSource = ctx.LigneSet.ToList();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException )
                    {
                        MessageBox.Show("la Ligne est déja utilisé dans une morasse");
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

                }
            }

        }
    }
}
