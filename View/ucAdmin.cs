using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using View;

namespace View
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }

        private void ucAdmin_Load(object sender, EventArgs e)
        {

        }

        private void labelStock_Click(object sender, EventArgs e)
        {
            ucStock stock = new ucStock();
            this.panelAdmin.Controls.Clear();
            this.panelAdmin.Controls.Add(stock);
        }

        private void labelVente_Click(object sender, EventArgs e)
        {
            usVenteAdmin vente = new usVenteAdmin();
            this.panelAdmin.Controls.Clear();
            this.panelAdmin.Controls.Add(vente);
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            ucUser user = new ucUser();
            this.panelAdmin.Controls.Clear();
            this.panelAdmin.Controls.Add(user);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
