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

                cb_Morasse.ValueMember = "Code";
                cb_Morasse.DisplayMember = "Code";
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
                using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {

                    ctx.Entry(bc).State = System.Data.Entity.EntityState.Deleted;
                    ctx.BCSet.Remove(bc);
                    ctx.SaveChanges();
                    MessageBox.Show("Supprimé avec succès");
                    cb_NumBc.DataSource = ctx.BCSet.ToList();

                }
            }
            catch(Exception ex)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    cb_Morasse.SelectedValue = bc.InfoMorasse.Code;
                    cb_Pvj.SelectedValue = bc.InfoPVJ.IdPVJ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
