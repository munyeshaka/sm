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
                Actualiser();
                Reinitialiser();
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

        private void btnModifierUser_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment Modifier ces donnees??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    u = new User();
                    u.IdUser = tidUser.Text;
                    u.Usernom = tusername.Text;
                    u.Password = tPassword.Text;


                    try
                    {
                        int line = Factory.modifierUser(u);

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

        void recupererUser(User u)
        {
            tidUser.Text = u.IdUser;
            tusername.Text = u.Usernom;
            tPassword.Text = u.Password;

        }
        private void btnRechercheUser_Click(object sender, EventArgs e)
        {
            string ma = tRechercheUser.Text.Trim();
            u = Factory.getUserRechercheByid(ma);
            if (u != null)
            {
                recupererUser(u);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            listUser = Factory.getUser();
            dgvUser.DataSource = listUser;
            Reinitialiser();
        }
        private void Actualiser()
        {
            listUser = Factory.getUser();
            dgvUser.DataSource = listUser;
        }
        private void Reinitialiser()
        {
            tidUser.Text = "";
            tusername.Text = "";
            tPassword.Text = "";
            tRechercheUser.Text = "";

        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                tidUser.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
                tusername.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
                tPassword.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
                tRechercheUser.Text = "";
            }
        }

        private void btnSupprimerUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce resident??", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        int line = Factory.deleteUser(tidUser.Text);
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
