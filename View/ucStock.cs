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

    public partial class ucStock : UserControl
    {
        ArrayList listStock = new ArrayList();
        Produit p = null;
        public ucStock()
        {
            InitializeComponent();
        }


        string GenererMatri(Produit pr)
        {
            int nbre = Factory.getProduit().Count + 1;
            string matri = pr.NomProduit.Substring(0, 3);
            matri = matri + nbre.ToString();
            return matri;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            p = new Produit();
            p.NomProduit = tNomProd.Text;
            p.IdProduit = GenererMatri(p);
            p.PrixProduit = tPrixProd.Text;
            p.QteProduit = tQuantiteProd.Text;
          
            try
            {
                int line = Factory.insertProduit(p);

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

        private void ucStock_Load(object sender, EventArgs e)
        {
            listStock = Factory.getProduit();
            dgvStock.DataSource = listStock;

            dgvStock.Columns[0].HeaderText = "#";
            dgvStock.Columns[1].HeaderText = "Nom du produit";
            dgvStock.Columns[2].HeaderText = "Prix du produit";
            dgvStock.Columns[3].HeaderText = "Quantite du produit disponible";
            //dgvStock.Columns[4].HeaderText = "Prix Totat";



        }
    }
}
