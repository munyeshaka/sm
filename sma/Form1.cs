using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace sma
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucVente vente = new ucVente();
            this.HomePanel.Controls.Clear();
            this.HomePanel.Controls.Add(vente);
        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucAdminLogin login = new ucAdminLogin();
            this.HomePanel.Controls.Clear();
            this.HomePanel.Controls.Add(login);
        }
    }
}
