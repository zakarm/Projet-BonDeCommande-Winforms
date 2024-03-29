﻿using System;
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
    public partial class GestionCompteForm : Form
    {
        public GestionCompteForm()
        {
            InitializeComponent();
        }

        private void GestionCompteForm_Load(object sender, EventArgs e)
        {
            using(OnssaModelContainer4 ctx= new OnssaModelContainer4())
            {
                cb_Numcompte.DisplayMember = "Nom";
                cb_Numcompte.ValueMember = "id";
                cb_Numcompte.DataSource = ctx.GestionCompteSet.ToList();
            }
        }

        GestionCompte og;
        

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    if (txt_motdepasse.Text.Equals(txt_conf_mot_de_passe.Text))
                    {
                        GestionCompte g = new GestionCompte();

                        g.Nom = cb_Numcompte.Text.ToString();
                        g.MotDePasse = txt_motdepasse.Text.ToString();
                        g.TypeCompte = txt_typeccompte.Text.ToString();

                        ctx.GestionCompteSet.Add(g);

                        ctx.SaveChanges();
                        MessageBox.Show("Ajouté avec succès");
                        cb_Numcompte.DataSource = ctx.GestionCompteSet.ToList();
                        DeclarationGlobale.vider(this);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez confirmer votre mot de passe !");
                    }
                }
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
                    if (txt_motdepasse.Text.Equals(txt_conf_mot_de_passe.Text))
                    {
                        ctx.Entry(og).State = System.Data.Entity.EntityState.Modified;
                        og.Nom = cb_Numcompte.Text.ToString();
                        og.MotDePasse = txt_motdepasse.Text.ToString();
                        og.TypeCompte = txt_typeccompte.Text.ToString();
                        og.TypeCompte = txt_typeccompte.Text.ToString();
                        ctx.SaveChanges();
                        MessageBox.Show("Modifié avec succès");
                        cb_Numcompte.DataSource = ctx.GestionCompteSet.ToList();
                        DeclarationGlobale.vider(this);
                    }
                    else
                        MessageBox.Show("Veuillez confirmer votre mot de passe !");

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
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                    ctx.Entry(og).State = System.Data.Entity.EntityState.Deleted;
                    ctx.GestionCompteSet.Remove(og);
                    ctx.SaveChanges();
                    cb_Numcompte.DataSource = ctx.GestionCompteSet.ToList();
                }
                MessageBox.Show("Supprimé avec succès");
                DeclarationGlobale.vider(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Numcompte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            { 
                using (OnssaModelContainer4 ctx = new OnssaModelContainer4())
                {
                        og = ctx.GestionCompteSet.Find(cb_Numcompte.SelectedValue);

                        txt_motdepasse.Text = og.MotDePasse.ToString();
                        txt_typeccompte.Text = og.TypeCompte.ToString();
                        txt_conf_mot_de_passe.Text = og.MotDePasse.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
