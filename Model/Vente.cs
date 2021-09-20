using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Vente
    {
        string idProduitVente, nomProduitVente;
        float prixProduitVente, qteProduitVente, totalVente;

        public string IdProduitVente
        {
            get { return idProduitVente; }
            set { idProduitVente = value; }
        }
        public string NomProduitVente
        {
            get { return nomProduitVente; }
            set { nomProduitVente = value; }
        }
        public float PrixProduitVente
        {
            get { return prixProduitVente; }
            set { prixProduitVente = value; }
        }
        public float QteProduitVente
        {
            get { return qteProduitVente; }
            set { qteProduitVente = value; }
        }
        public float TotalVente
        {
            get { return totalVente; }
            set { totalVente = value; }
        }

        
    }
}
