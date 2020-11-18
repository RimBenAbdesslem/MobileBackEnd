using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class CategorieModel
    {
        [Key]
        public int CategorieId { get; set; }
        public string NomCategorie { get; set; }
        //domaine have a liste of label 
        public ICollection<SCategorieModel> SCategories { get; set; }
    }
}
