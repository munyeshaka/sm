using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produit
    {
        string idProduit, nomProduit, prixProduit, qteProduit;

        public string IdProduit
        {
            get { return idProduit; }
            set { idProduit = value; }
        }
        public string NomProduit
        {
            get { return nomProduit; }
            set { nomProduit = value; }
        }
        public string PrixProduit
        {
            get { return prixProduit; }
            set { prixProduit = value; }
        }
        public string QteProduit
        {
            get { return qteProduit; }
            set { qteProduit = value; }
        }
    }
}
