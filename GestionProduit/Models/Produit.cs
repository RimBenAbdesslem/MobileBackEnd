using System;

namespace GestionProduit.Models
{
    public class Produit
    {

        public int ProduitId { get; set; }

    
        public string Nom { get; set; }

        public string Description { get; set; }

        public float Prix { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string NonFournisseur { get; set; }
        public int Priorite { get; set; }

        public string Scategorie { get; set; }
        public int CategorieId { get; set; }
        public string Categorie { get; set; }

        public int TypeId { get; set; }
        

        public int Quantite { get; set; }

        public string Image { get; set; }

    }
}
