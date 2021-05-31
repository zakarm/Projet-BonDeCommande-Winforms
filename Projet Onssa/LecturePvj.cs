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
    public partial class LecturePvj : Form
    {
        public LecturePvj()
        {
            InitializeComponent();
        }

        
        private void LecturePvj_Load(object sender, EventArgs e)
        {

            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Pvj.ValueMember = "IdPVJ";
                cb_Pvj.DisplayMember = "NumPvj";
                cb_Pvj.DataSource = ctx.PVJSet.ToList();
            }
        }

        private void cb_Pvj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataSetPvj ds = new DataSetPvj();
                DataRow row;

                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    var query = from pvj in ctx.PVJSet
                                join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                                m.InfoFournisseur.IdFournisseur
                                where pvj.IdPVJ == (int)cb_Pvj.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                                select new
                                {
                                    IdCon = pvj.InfoConsultation.IdConsultation,
                                    NomFr = m.InfoFournisseur.Nom,
                                    Objet = m.InfoConsultation.ObjetConsultation,
                                    IdPvj = pvj.IdPVJ,
                                    NumCon = pvj.InfoConsultation.NumConsultation,
                                    NumDevis = m.NumDevis,
                                    IdDevis = m.IdModeleDevis,
                                    Tva = m.Tva,
                                    Ttc = m.Ttc,
                                    thc = m.Total,
                                    DatePvj = pvj.DatePvj,

                                };
                    
                    NumToString cc = new NumToString();
                    
                    if(query.FirstOrDefault() !=null)
                    {

                        foreach (Fournisseur f in ctx.PVJSet.Find(query.FirstOrDefault().IdPvj).ListFournisseursRepondu)
                        {
                            row = ds.FournisseurReponduSet.NewRow();
                            row[0] = f.Nom;
                            ds.FournisseurReponduSet.Rows.Add(row);
                            
                        }

                        foreach (Fournisseur f in ctx.ConsultationSet.Find(query.FirstOrDefault().IdCon).ListFournisseur)
                        {
                            
                            
                            row = ds.FournisseurCon.NewRow();
                            row[0] = f.Nom;
                            ds.FournisseurCon.Rows.Add(row);

                            var query2 = from  md in ctx.ModeleDevisSet 
                                        where md.InfoFournisseur.IdFournisseur == f.IdFournisseur && md.InfoConsultation.IdConsultation == query.FirstOrDefault().IdCon
                                         select new
                                        {
                                            IdDevis = md.IdModeleDevis,
                                        };

                            if (query2.FirstOrDefault() != null)
                            {
                                ModeleDevis m = ctx.ModeleDevisSet.Find(query2.FirstOrDefault().IdDevis);
                                row = ds.Devis.NewRow();
                                row[0] = m.InfoFournisseur.Nom;
                                row[1] = m.IdModeleDevis;
                                row[2] = m.Date;
                                row[3] = m.Ttc;
                                ds.Devis.Rows.Add(row);
                            }

                        }

                        foreach (Commission c in ctx.PVJSet.Find(query.FirstOrDefault().IdPvj).ListCommissions)
                        {
                           
                            row = ds.CommissionSet.NewRow();
                            row[1] = c.Nom;
                            row[2] =c.Prenom;
                            row[3] = c.Fonction;
                            row[4] = c.Affectation;
                            ds.CommissionSet.Rows.Add(row);
                        }

                        
                        DateTime d = query.FirstOrDefault().DatePvj;
                        NumToString num = new NumToString();
                        DateToString dt = new DateToString();
                        string s = "L'an "+ num.Ninetotwelvedigit(d.Year.ToString())+" le "+num.Ninetotwelvedigit(d.Day.ToString()) +" du mois de "+ dt.DateMounth(d.Month);
                        CrystalReportPvj ce = new CrystalReportPvj();
                        ce.SetDataSource(ds);
                        ce.SetParameterValue("nom", query.FirstOrDefault().NomFr.ToString());
                        ce.SetParameterValue("objet", query.FirstOrDefault().Objet.ToString());
                        ce.SetParameterValue("thc", query.FirstOrDefault().thc.ToString());
                        ce.SetParameterValue("tva", query.FirstOrDefault().Tva.ToString());
                        ce.SetParameterValue("ttc", query.FirstOrDefault().Ttc.ToString());
                        ce.SetParameterValue("datepvj", query.FirstOrDefault().DatePvj.ToString());
                        ce.SetParameterValue("numcon", query.FirstOrDefault().NumCon.ToString());
                        ce.SetParameterValue("date", s);
                        ce.SetParameterValue("numm", cc.virgule(query.FirstOrDefault().Ttc.ToString()));
                        crystalReportViewer1.ReportSource = ce;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("le fournisseur choisie dans le procès verbal de jugement n'a pas un modele de devis");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
