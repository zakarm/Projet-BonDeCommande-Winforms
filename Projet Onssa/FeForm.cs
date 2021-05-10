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
    public partial class FeForm : Form
    {
        public FeForm()
        {
            InitializeComponent();
        }
        FE ff;

        private void FeForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumFe.DisplayMember = "NumFe";
                cb_NumFe.ValueMember = "IdFE";
                cb_NumFe.DataSource = ctx.FESet.ToList();

                cb_Bc.DisplayMember = "NumBc";
                cb_Bc.ValueMember = "IdBC";
                cb_Bc.DataSource = ctx.BCSet.ToList();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    FE fe = new FE();
                    BC bc = ctx.BCSet.Find(cb_Bc.SelectedValue);

                    fe.NumFe = cb_NumFe.Text;
                    fe.CreditsBudgetaires = int.Parse(txt_Budgetaires.Text);
                    fe.DepensesEngagees = int.Parse(txt_DepensesE.Text);
                    fe.Disponible = int.Parse(txt_Dispo.Text);
                    fe.EngagementDepensesPropose = int.Parse(txt_engagementDP.Text);
                    fe.InfoBC = bc;

                    ctx.FESet.Add(fe);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");

                    cb_NumFe.DataSource = ctx.FESet.ToList();

                   
                }
                DeclarationGlobale.vider(this);
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

                    ctx.Entry(ff).State = System.Data.Entity.EntityState.Deleted;
                    ctx.FESet.Remove(ff);
                    ctx.SaveChanges();
                    MessageBox.Show("Supprimé avec succès");
                    DeclarationGlobale.vider(this);
                    cb_NumFe.DataSource = ctx.FESet.ToList();
                    
                }
                
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException o)
            {
                MessageBox.Show("cette FE déja Utilisé dans autre form Ne peut pas etre supprimer");
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

                    ctx.Entry(ff).State = System.Data.Entity.EntityState.Modified;

                    BC bc = ctx.BCSet.Find(cb_Bc.SelectedValue);
                    ff.NumFe = cb_NumFe.Text;
                    ff.CreditsBudgetaires = int.Parse(txt_Budgetaires.Text);
                    ff.DepensesEngagees = int.Parse(txt_DepensesE.Text);
                    ff.Disponible = int.Parse(txt_Dispo.Text);
                    ff.EngagementDepensesPropose = int.Parse(txt_engagementDP.Text);
                    ff.InfoBC = bc;

                    ctx.SaveChanges();
                    MessageBox.Show("Modifé avec succès");

                    cb_NumFe.DataSource = ctx.FESet.ToList();

                }
                DeclarationGlobale.vider(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void cb_NumFe_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ff = ctx.FESet.Find(cb_NumFe.SelectedValue);
                    txt_Budgetaires.Text = ff.CreditsBudgetaires.ToString();
                    txt_DepensesE.Text = ff.DepensesEngagees.ToString();
                    txt_Dispo.Text = ff.Disponible.ToString();
                    txt_engagementDP.Text = ff.EngagementDepensesPropose.ToString();
                    cb_Bc.SelectedValue = ff.InfoBC.IdBC;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void cb_Bc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from bc in ctx.BCSet 
                             join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                             join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                             m.InfoFournisseur.IdFournisseur
                             join fr in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals fr.IdFournisseur
                            where bc.IdBC == (int)cb_Bc.SelectedValue
                             select new
                             {
                                 ttc = m.Ttc,
                                 nom = fr.Nom,

                             };
                if(query.FirstOrDefault()!=null)
                {
                    label_fournisseur.Text = query.FirstOrDefault().nom.ToString();
                    label_ttc.Text = query.FirstOrDefault().ttc.ToString();
                    label_bc.Text = cb_Bc.Text;
                }

            }
            
        }
    }
    
}
