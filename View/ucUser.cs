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
    public partial class ucUser : UserControl
    {
        ArrayList listUser = new ArrayList();
        User u = null;

        public ucUser()
        {
            InitializeComponent();
        }


        string GenererMatri(User usr)
        {
            int nbre = Factory.getUser().Count + 1;
            string matri = usr.Usernom.Substring(0, 3);
            matri = matri + nbre.ToString();
            return matri;
        }
        private void btnAjouterUser_Click(object sender, EventArgs e)
        {
            u = new User();
            u.Usernom = tusername.Text;
            u.IdUser = GenererMatri(u);
            u.Password = tPassword.Text;

            try
            {
                int line = Factory.insertUser(u);

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

        private void ucUser_Load(object sender, EventArgs e)
        {
            listUser = Factory.getUser();
            dgvUser.DataSource = listUser;

            dgvUser.Columns[0].HeaderText = "#";
            dgvUser.Columns[1].HeaderText = "Nom d'utilisateur";
            dgvUser.Columns[2].HeaderText = "Mot de passe";
        }
    }
}
