using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Controller;
using Model;

namespace View
{
    public partial class ucAdminLogin : UserControl
    {
        ArrayList listUser = new ArrayList();
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True");

        User u = null;
        public ucAdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ucAdmin admin = new ucAdmin();
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(admin);*/

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "SELECT * FROM dbo.utilisateur";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                u = new User();
                u.IdUser = reader["idUser"].ToString();
                u.Usernom = reader["username"].ToString();
                u.Password = reader["userPassword"].ToString();

                string usa = tuserLogin.Text;
                string pa = tpassLogin.Text;
                string usadb = reader["username"].ToString();
                string padb = reader["userPassword"].ToString();


                if (usadb == usa && padb == pa)
                {
                    /*usAdmin admin = new usAdmin();
                    admin.show();*/
                    ucAdmin admin = new ucAdmin();
                    this.AdminPanel.Controls.Clear();
                    this.AdminPanel.Controls.Add(admin);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucAdminLogin login = new ucAdminLogin();
            this.AdminPanel.Controls.Clear();
            this.AdminPanel.Controls.Add(login);
        }
    }
}
    

