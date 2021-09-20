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
                //Actualiser();
                //Reinitialiser();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
