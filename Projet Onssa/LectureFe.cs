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
    public partial class LectureFe : Form
    {
        public LectureFe()
        {
            InitializeComponent();
        }

        private void LectureFe_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                cb_Fe.ValueMember = "IdFE";
                cb_Fe.DisplayMember = "NumFE";
                cb_Fe.DataSource = ctx.FESet.ToList();

            }
                

        }

        private void cb_Fe_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
            {
                var query = from fe in ctx.FESet
                            join bc in ctx.BCSet on fe.InfoBC.IdBC equals bc.IdBC
                            join pvj in ctx.PVJSet on bc.InfoPVJ.IdPVJ equals pvj.IdPVJ
                            join m in ctx.ModeleDevisSet on pvj.InfoFournisseur.IdFournisseur equals
                            m.InfoFournisseur.IdFournisseur
                            join fr in ctx.FournisseurSet on m.InfoFournisseur.IdFournisseur equals fr.IdFournisseur
                            where fe.IdFE == (int)cb_Fe.SelectedValue && m.InfoConsultation.IdConsultation == pvj.InfoConsultation.IdConsultation
                            select new
                            {
                                AdresseFour= fr.Adresse,
                                Cnss=fr.CNSS_n,
                                Ifn=fr.IF_n,
                                Patente=fr.Patente_n,
                                Numfe = fe.NumFe,
                                total = m.Ttc,
                                NumBc = bc.NumBc,
                                NomFr = fr.Nom,
                                DateBc = bc.DateBC,
                                Code = bc.InfoMorasse.Code,
                                Objet = m.InfoConsultation.ObjetConsultation,
                                Exercice = bc.InfoMorasse.Exercice,
                                Compte = fr.Compte_bancaire_n,
                            };
            }

        }
    }
}
