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
    public partial class OiForm : Form
    {
        public OiForm()
        {
            InitializeComponent();
        }

        OI oi;
        private void OiForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumOi.DisplayMember = "NumOi";
                cb_NumOi.ValueMember = "IdOI";
                cb_NumOi.DataSource = ctx.OISet.ToList();

                cb_Fe.DisplayMember = "NumFe";
                cb_Fe.ValueMember = "IdFE";
                cb_Fe.DataSource = ctx.FESet.ToList();
            }
        }

     
      

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    OI Oiajoute = new OI();
                    FE fe = ctx.FESet.Find(cb_Fe.SelectedValue);

                    Oiajoute.NumOi = cb_NumOi.Text;
                    Oiajoute.NumCompteDebit = txt_Compte.Text;
                    Oiajoute.VisaControle = txt_VisaControl.Text;
                    Oiajoute.VisaCsrs = txt_VisaCsrs.Text;
                    Oiajoute.VisaSordonnateur = txt_VisaSordonnateur.Text;
                    Oiajoute.VisaTresorierPayeur = txt_VisaTresorier.Text;
                    Oiajoute.DatePaiement = data_Paiement.Value;
                    Oiajoute.DateOI = date_Oi.Value;
                    Oiajoute.InfoFE = fe;


                    ctx.OISet.Add(Oiajoute);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                    DeclarationGlobale.vider(this);
                    cb_NumOi.DataSource = ctx.OISet.ToList();
                }
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
                        ctx.Entry(oi).State = System.Data.Entity.EntityState.Deleted;
                        ctx.OISet.Remove(oi);
                        ctx.SaveChanges();
                        MessageBox.Show("Supprimé avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumOi.DataSource = ctx.OISet.ToList();
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
                        ctx.Entry(oi).State = System.Data.Entity.EntityState.Modified;

                        FE fE = ctx.FESet.Find(cb_Fe.SelectedValue);

                        oi.NumOi = cb_NumOi.Text;
                        oi.NumCompteDebit = txt_Compte.Text;
                        oi.VisaControle = txt_VisaControl.Text;
                        oi.VisaCsrs = txt_VisaCsrs.Text;
                        oi.VisaSordonnateur = txt_VisaSordonnateur.Text;
                        oi.VisaTresorierPayeur = txt_VisaTresorier.Text;
                        oi.DatePaiement = data_Paiement.Value;
                        oi.DateOI = date_Oi.Value;
                        oi.InfoFE = fE;

                        ctx.SaveChanges();
                        MessageBox.Show("Modifé avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumOi.DataSource = ctx.OISet.ToList();
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

      
        private void cb_NumOi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    oi = ctx.OISet.Find(cb_NumOi.SelectedValue);
                    cb_Fe.Text = oi.InfoFE.NumFe.ToString();
                    txt_Compte.Text = oi.NumCompteDebit.ToString();
                    txt_VisaControl.Text = oi.VisaControle.ToString();
                    txt_VisaCsrs.Text = oi.VisaCsrs.ToString();
                    txt_VisaSordonnateur.Text = oi.VisaSordonnateur.ToString();
                    txt_VisaTresorier.Text = oi.VisaTresorierPayeur.ToString();
                    data_Paiement.Value = oi.DatePaiement;
                    date_Oi.Value = oi.DateOI;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
