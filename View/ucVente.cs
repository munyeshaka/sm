using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Controller;
using Model;

namespace View
{
    public partial class ucVente : UserControl
    {
        ArrayList listVente = new ArrayList();
        Vente v = null;

        public ucVente()
        {
            InitializeComponent();
        }

        private void ucVente_Load(object sender, EventArgs e)
        {
            listVente = Factory.getVente();
            dgvVente.DataSource = listVente;

            dgvVente.Columns[0].HeaderText = "#";
            dgvVente.Columns[1].HeaderText = "Nom du produit";
            dgvVente.Columns[2].HeaderText = "Prix du produit";
            dgvVente.Columns[3].HeaderText = "Quantite du produit";
            dgvVente.Columns[4].HeaderText = "Prix Totat";
        }


        string GenererMatri(Vente ve)
        {
            int nbre = Factory.getVente().Count + 1;
            string matri = ve.NomProduitVente.Substring(0, 3);
            matri = matri + nbre.ToString();
            return matri;
        }
        private void btnAjouterVente_Click(object sender, EventArgs e)
        {
            v = new Vente();
            v.NomProduitVente = tNomProdVente.Text;
            v.IdProduitVente = GenererMatri(v);
            v.PrixProduitVente = float.Parse(tPrixProdVente.Text);
            v.QteProduitVente = float.Parse(tQuantiteProdVente.Text);

            try
            {
                int line = Factory.insertVente(v);

                if (line != 0)
                    MessageBox.Show("Enregistrement reussi");
                Actualiser();
                Reinitialiser();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void recupererVente(Vente v)
        {
            tidProdVente.Text = v.IdProduitVente;
            tNomProdVente.Text = v.NomProduitVente;
            tPrixProdVente.Text = (v.PrixProduitVente).ToString();
            tQuantiteProdVente.Text = (v.QteProduitVente).ToString();

        }
        private void btnRechercheVente_Click(object sender, EventArgs e)
        {
            string ma = tRechercheVente.Text.Trim();
            v = Factory.getVenteRechercheByid(ma);
            if (v != null)
            {
                recupererVente(v);
            }
        }

        private void btnModifierVente_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment Modifier ces donnees??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    v = new Vente();
                    v.NomProduitVente = tNomProdVente.Text;
                    v.IdProduitVente = tidProdVente.Text;
                    v.PrixProduitVente = float.Parse(tPrixProdVente.Text);
                    v.QteProduitVente = float.Parse(tQuantiteProdVente.Text);


                    try
                    {
                        int line = Factory.modifierProduit(v);

                        if (line != 0)
                            MessageBox.Show("Modification Reussie");
                        Actualiser();
                        Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Votre donnees a ete modifiees !!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre donnees n'a pas ete modifiees!!");
                    break;
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            listVente = Factory.getVente();
            dgvVente.DataSource = listVente;
            Reinitialiser();
        }
        private void Actualiser()
        {
            listVente = Factory.getVente();
            dgvVente.DataSource = listVente;
        }
        private void Reinitialiser()
        {
            tidProdVente.Text = "";
            tNomProdVente.Text = "";
            tPrixProdVente.Text = "";
            tQuantiteProdVente.Text = "";
            tRechercheVente.Text = "";

        }

        private void dgvVente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVente.SelectedRows.Count > 0)
            {
                tidProdVente.Text = dgvVente.SelectedRows[0].Cells[0].Value.ToString();
                tNomProdVente.Text = dgvVente.SelectedRows[0].Cells[1].Value.ToString();
                tPrixProdVente.Text = dgvVente.SelectedRows[0].Cells[2].Value.ToString();
                tQuantiteProdVente.Text = dgvVente.SelectedRows[0].Cells[3].Value.ToString();
                tRechercheVente.Text = "";
            }
        }

        private void btnSupprimerVente_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce resident??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        int line = Factory.deleteVente(tidProdVente.Text);
                        if (line != 0)
                            MessageBox.Show("Suppression reussi");
                        Actualiser();
                        Reinitialiser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Votre donnees a ete supprime ...");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Votre donnees n'a pas ete supprime ...");
                    break;

            }
        }
    }
}
