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
using System.Data.Sql;
using System.Linq.Expressions;
using System.Data.SqlTypes;

namespace Projet_Onssa
{
    public partial class BcForm : Form
    {
        public BcForm()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(32, 38,50), Color.FromArgb(32, 38, 50), Color.FromArgb(32, 38, 50), Color.FromArgb(32, 38, 50), TextShade.WHITE);

        }

        BC bc;

        private void BcForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumBc.DisplayMember = "NumBc";
                cb_NumBc.ValueMember = "IdBC";
                cb_NumBc.DataSource = ctx.BCSet.ToList();

                cb_Morasse.ValueMember = "CodeMorasse";
                cb_Morasse.DisplayMember = "CodeMorasse";
                cb_Morasse.DataSource = ctx.MorasseSet.ToList();

                cb_Pvj.ValueMember = "IdPVJ";
                cb_Pvj.DisplayMember = "NumPvj";
                cb_Pvj.DataSource = ctx.PVJSet.ToList();

            }
        }

        private void viderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DeclarationGlobale.vider(this);
        }

      

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            { 
                using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    BC b = new BC();
                    PVJ p = ctx.PVJSet.Find(cb_Pvj.SelectedValue);
                    Morasse m = ctx.MorasseSet.Find(cb_Morasse.SelectedValue);
                    b.NumBc = cb_NumBc.Text;
                    b.DateBC = date_Bc.Value;
                    b.DelaiExecution = txt_Delai.Text;
                    b.Destination = txt_Destination.Text;
                    b.InfoMorasse = m;
                    b.InfoPVJ = p;
                    ctx.BCSet.Add(b);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                   cb_NumBc.DataSource = ctx.BCSet.ToList();
                    

                }
                DeclarationGlobale.vider(this);

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
                       ctx.Entry(bc).State = System.Data.Entity.EntityState.Deleted;
                    ctx.BCSet.Remove(bc);
                    ctx.SaveChanges();
                    MessageBox.Show("Supprimé avec succès");
                    cb_NumBc.DataSource = ctx.BCSet.ToList();
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }

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
                        ctx.Entry(bc).State = System.Data.Entity.EntityState.Modified;
                        PVJ p = ctx.PVJSet.Find(cb_Pvj.SelectedValue);
                        Morasse m = ctx.MorasseSet.Find(cb_Morasse.SelectedValue);
                        bc.NumBc = cb_NumBc.Text;
                        bc.DateBC = date_Bc.Value;
                        bc.DelaiExecution = txt_Delai.Text;
                        bc.Destination = txt_Destination.Text;
                        bc.InfoMorasse = m;
                        bc.InfoPVJ = p;
                        ctx.SaveChanges();
                        MessageBox.Show("Modifié avec succès");
                        cb_NumBc.DataSource = ctx.BCSet.ToList();
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
            else DeclarationGlobale.vider(this);

        }

       

        private void cb_NumBc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    bc = ctx.BCSet.Find(cb_NumBc.SelectedValue);
                    txt_Delai.Text = bc.DelaiExecution;
                    txt_Destination.Text = bc.Destination;
                    date_Bc.Value = bc.DateBC;
                    cb_Morasse.Text = bc.InfoMorasse.CodeMorasse.ToString();
                    cb_Pvj.Text = bc.InfoPVJ.IdPVJ.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Pvj_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from pvj in ctx.PVJSet
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                join fr in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals fr.IdFournisseur
                                join con in ctx.ConsultationSet on pvj.InfoConsultation.IdConsultation equals con.IdConsultation
                                where pvj.IdPVJ == (int)cb_Pvj.SelectedValue
                                select new
                                {
                                    ttc = m.Ttc,
                                    nom = fr.Nom,
                                    tva = m.Tva,
                                    thttva = m.Total,
                                    objet = con.ObjetConsultation,

                                };

                    label_fournisseur.Text = query.FirstOrDefault().nom.ToString();
                    label_ttc.Text = query.FirstOrDefault().ttc.ToString();
                    label_tva.Text = query.FirstOrDefault().tva.ToString();
                    label_thttva.Text = query.FirstOrDefault().thttva.ToString();
                    label_objet.Text = query.FirstOrDefault().objet.ToString();
            }
                
        }
    }

}
