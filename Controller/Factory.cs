using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using Model;


namespace Controller
{

    public class Factory
    {
        public static ArrayList listStock = new ArrayList();

        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UCVVLMH\\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True");
    

        //=======================AFFICHER Product==============

        public static ArrayList getProduit()
        {
            ArrayList produit = new ArrayList();
            ArrayList vente = new ArrayList();
            Produit p = null;
            Vente v = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.product";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                p = new Produit();
                p.IdProduit = reader["idProd"].ToString();
                p.NomProduit = reader["nomProd"].ToString();
                p.PrixProduit = reader["prix"].ToString();
                p.QteProduit = reader["qteProd"].ToString();

                produit.Add(p);

            }

            reader.Close();
            conn.Close();
            return produit;

        }

        //=======================INSERT produit==============

        public static int insertProduit(Produit p)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.product (idProd, nomProd, prix, qteProd)  values (@id,@no,@pr,@qt)";

            commande.Parameters.Add(new SqlParameter("@id", p.IdProduit));
            commande.Parameters.Add(new SqlParameter("@no", p.NomProduit));
            commande.Parameters.Add(new SqlParameter("@pr", p.PrixProduit));
            commande.Parameters.Add(new SqlParameter("@qt", p.QteProduit));

            int n = commande.ExecuteNonQuery();

            return n;
        }
        //=======================END INSERT produit==============

        //=======================affichage vente==============

        public static ArrayList getVente()
        {
            ArrayList vente = new ArrayList();
            Vente v = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "SELECT idProdVente, nomProdVente, prixProdVente, qteProdVente FROM dbo.vente";
            SqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                v = new Vente();
                v.IdProduitVente = reader["idProdVente"].ToString();
                v.NomProduitVente = reader["nomProdVente"].ToString();
                v.PrixProduitVente = float.Parse(reader["prixProdVente"].ToString());
                v.QteProduitVente = float.Parse(reader["qteProdVente"].ToString());

                float a = float.Parse(reader["prixProdVente"].ToString());
                float b = float.Parse(reader["qteProdVente"].ToString());
                float c = a*b;

                v.TotalVente = c;

                vente.Add(v);

            }

            reader.Close();
            conn.Close();
            return vente;

        }
        //=======================INSERT produit==============

        public static int insertVente(Vente v)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.vente (idProdVente, nomProdVente, prixProdVente, qteProdVente)  values (@id,@no,@pr,@qt)";

            commande.Parameters.Add(new SqlParameter("@id", v.IdProduitVente));
            commande.Parameters.Add(new SqlParameter("@no", v.NomProduitVente));
            commande.Parameters.Add(new SqlParameter("@pr", v.PrixProduitVente));
            commande.Parameters.Add(new SqlParameter("@qt", v.QteProduitVente));

            int n = commande.ExecuteNonQuery();

            return n;
        }
        //=======================END INSERT produit==============

        //=======================affichage user==============

        public static ArrayList getUser()
        {
            ArrayList user = new ArrayList();
            User u = null;

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

                user.Add(u);

            }

            reader.Close();
            conn.Close();
            return user;

        }
        //=======================INSERT user==============

        public static int insertUser(User u)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "insert into dbo.utilisateur (idUser, username, userPassword)  values (@id,@usa,@pass)";

            commande.Parameters.Add(new SqlParameter("@id", u.IdUser));
            commande.Parameters.Add(new SqlParameter("@usa", u.Usernom));
            commande.Parameters.Add(new SqlParameter("@pass", u.Password));

            int n = commande.ExecuteNonQuery();

            return n;
        }
        //=======================END INSERT user==============

        //======================= MODIFIER produit==============
        public static int modifierProduit(Produit p)
        {

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;

            commande.CommandText = "update dbo.product set idProd=@idp, nomProd=@no, prix=@pri, qteProd=@q where idProd=@idp";

            commande.Parameters.Add(new SqlParameter("@idp", p.IdProduit));
            commande.Parameters.Add(new SqlParameter("@no", p.NomProduit));
            commande.Parameters.Add(new SqlParameter("@pri", p.PrixProduit));
            commande.Parameters.Add(new SqlParameter("@q", p.QteProduit));


            int n = commande.ExecuteNonQuery();
            return n;

        }////=======================END MODIFIER produit==============
        //=======================RECHERCHE Produit==============

        public static Produit getProduitRechercheByid(string idProd)
        {
            ArrayList pro = new ArrayList();
            Produit p = null;

            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "select * from dbo.product where idProd=@idp";
            commande.Parameters.Add(new SqlParameter("@idp", idProd));
            SqlDataReader reader = commande.ExecuteReader();

            if (reader.Read())
            {
                p = new Produit();

                p.IdProduit = reader["idProd"].ToString();
                p.NomProduit = reader["nomProd"].ToString();
                p.PrixProduit = reader["prix"].ToString();
                p.QteProduit = reader["qteProd"].ToString();

            }

            reader.Close();
            conn.Close();
            return p;

        }//=======================END RECHERCHE produit==============

        //======================= SUPRRIMER produit==============
        public static int deleteProduit(string idp)
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
            SqlCommand commande = new SqlCommand();
            commande.Connection = conn;
            commande.CommandText = "delete from dbo.product where idProd = @id";
            commande.Parameters.AddWithValue("@id", idp);
            int n = commande.ExecuteNonQuery();
            return n;
        }//=======================END SUPRRIMER RESIDENT==============
    }
}
