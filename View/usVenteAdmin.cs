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
    public partial class usVenteAdmin : UserControl
    {
        ArrayList listVente = new ArrayList();
        Vente v = null;
        public usVenteAdmin()
        {
            InitializeComponent();
        }

        private void usVenteAdmin_Load(object sender, EventArgs e)
        {
            listVente = Factory.getVente();
            dgvVente.DataSource = listVente;

            dgvVente.Columns[0].HeaderText = "#";
            dgvVente.Columns[1].HeaderText = "Nom du produit";
            dgvVente.Columns[2].HeaderText = "Prix du produit";
            dgvVente.Columns[3].HeaderText = "Quantite du produit";
            dgvVente.Columns[4].HeaderText = "Prix Totat";
        }

        private void btnRechercheVente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
