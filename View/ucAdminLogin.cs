using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace View
{
    public partial class ucAdminLogin : UserControl
    {
        public ucAdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucAdmin admin = new ucAdmin();
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(admin);
        }
    }
}
