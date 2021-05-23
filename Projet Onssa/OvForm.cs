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
    public partial class OvForm : Form
    {
        public OvForm()
        {
            InitializeComponent();
        }
        OV v = new OV();
        private void OvForm_Load(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_NumOv.DisplayMember = "NumOV";
                cb_NumOv.ValueMember = "IdOV";
                cb_NumOv.DataSource = ctx.OVSet.ToList();

                cb_Op.ValueMember = "IdOP";
                cb_Op.DisplayMember = "NumOP";
                cb_Op.DataSource = ctx.OPSet.ToList();
            }
            
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    OV ov = new OV();
                    OP op = ctx.OPSet.Find(cb_Op.SelectedValue);
                    ov.InfoOP = op;
                    ov.SousOrdonnateur = txt_Sordannateur.Text;
                    ov.TresorierPayeur = txt_tresorierpayeur.Text;
                    ov.NumOV = cb_NumOv.Text;

                    ctx.OVSet.Add(ov);
                    ctx.SaveChanges();
                    MessageBox.Show("Ajouté avec succès");
                    DeclarationGlobale.vider(this);
                    cb_NumOv.DataSource = ctx.OVSet.ToList();


                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("l'ordre de paiement est déjà utilisée dans un autre ordre de virment !");
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

        private void cb_NumOv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    v = ctx.OVSet.Find(cb_NumOv.SelectedValue);
                    txt_tresorierpayeur.Text = v.TresorierPayeur;
                    txt_Sordannateur.Text = v.SousOrdonnateur;
                    cb_NumOv.Text = v.NumOV;

                    var query = from ov in ctx.OVSet join
                                 op in ctx.OPSet on ov.InfoOP.IdOP equals op.IdOP
                                join oi in ctx.OISet on op.InfoOI.IdOI equals oi.IdOI
                                join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                select new
                                {
                                    OP = op.NumOP,
                                    OI = oi.NumOi,
                                    FE = fe.NumFe,
                                    BC = bc.NumBc,
                                    PVJ = pvj.IdPVJ,
                                };

                    dgv_Info.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        ctx.Entry(v).State = System.Data.Entity.EntityState.Modified;
                        OP op = ctx.OPSet.Find(cb_Op.SelectedValue);
                        v.InfoOP = op;
                        v.SousOrdonnateur = txt_Sordannateur.Text;
                        v.TresorierPayeur = txt_tresorierpayeur.Text;
                        v.NumOV = cb_NumOv.Text;

                        ctx.SaveChanges();
                        MessageBox.Show("Modifié avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumOv.DataSource = ctx.OVSet.ToList();

                        MessageBox.Show("Modifier avec succès");
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("l'ordre de paiement est déjà utilisée dans un autre ordre de virement !");
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
                        ctx.Entry(v).State = System.Data.Entity.EntityState.Deleted;
                        ctx.OVSet.Remove(v);
                        ctx.SaveChanges();
                        MessageBox.Show("Supprimé avec succès");
                        DeclarationGlobale.vider(this);
                        cb_NumOv.DataSource = ctx.OPSet.ToList();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException )
                    {
                        MessageBox.Show("lordre de virement est déja utilisé ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void cb_NumOv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    v = ctx.OVSet.Find(cb_NumOv.SelectedValue);
                    txt_tresorierpayeur.Text = v.TresorierPayeur;
                    txt_Sordannateur.Text = v.SousOrdonnateur;
                    cb_NumOv.Text = v.NumOV;

                    var query = from ov in ctx.OVSet
                                join
                                op in ctx.OPSet on ov.InfoOP.IdOP equals op.IdOP
                                join oi in ctx.OISet on op.InfoOI.IdOI equals oi.IdOI
                                join fe in ctx.FESet on oi.InfoFE.IdFE equals fe.IdFE
                                join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                                join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                                select new
                                {
                                    OP = op.NumOP,
                                    OI = oi.NumOi,
                                    FE = fe.NumFe,
                                    BC = bc.NumBc,
                                    PVJ = pvj.IdPVJ,
                                };

                    dgv_Info.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
