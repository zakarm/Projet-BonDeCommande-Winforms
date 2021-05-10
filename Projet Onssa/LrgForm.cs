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
    public partial class LrgForm : Form
    {
        public LrgForm()
        {
            InitializeComponent();
        }

        private void LrgForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_code.DisplayMember = "CodeLrg";
                cb_code.ValueMember = "CodeLrg";
                cb_code.DataSource = ctx.LrgSet.ToList();

                cb_numpara.DisplayMember = "NumPar";
                cb_numpara.ValueMember = "NumPar";
                cb_numpara.DataSource = ctx.ParagrapheSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    Paragraphe Op = ctx.ParagrapheSet.Find(cb_numpara.SelectedValue);
                    Lrg olrg = new Lrg();
                    olrg.NumLrg = cb_Num.Text.ToString();
                    olrg.InfoParagraphe = Op;
                    olrg.DescriptionLrg = txtarea_desc.Text;

                    olrg.CodeLrg = int.Parse(Op.NumPar.ToString() + cb_Num.Text.ToString());

                    ctx.LrgSet.Add(olrg);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                    DeclarationGlobale.vider(this);
                    cb_code.DataSource = ctx.LrgSet.ToList();

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

        Lrg lr;
        private void cb_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                try
                {
                    lr = ctx.LrgSet.Find(cb_code.SelectedValue);

                    cb_Num.Text = lr.NumLrg.ToString();
                    cb_numpara.Text = lr.InfoParagraphe.NumPar.ToString();
                    txtarea_desc.Text = lr.DescriptionLrg;

                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(lr).State = System.Data.Entity.EntityState.Modified;
                        Paragraphe Op = ctx.ParagrapheSet.Find(cb_numpara.SelectedValue);

                        lr.NumLrg = cb_Num.Text.ToString();
                        lr.InfoParagraphe = Op;
                        lr.DescriptionLrg = txtarea_desc.Text;

                        lr.CodeLrg = int.Parse(Op.NumPar.ToString() + cb_Num.Text.ToString());

                        ctx.SaveChanges();
                        MessageBox.Show("Modifier avec succès");
                        DeclarationGlobale.vider(this);
                        cb_code.DataSource = ctx.LrgSet.ToList();
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

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    try
                    {
                        ctx.Entry(lr).State = System.Data.Entity.EntityState.Modified;
                        ctx.LrgSet.Remove(lr);
                        ctx.SaveChanges();
                        cb_code.DataSource = ctx.LrgSet.ToList();
                        MessageBox.Show("Supprimer avec succès");
                        DeclarationGlobale.vider(this);
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
