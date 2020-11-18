using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class SCategorieModel
    {


        [Key]
        public int SCategIdId { get; set; }
        public string NomSCatego { get; set; }
        
        public int CategorieId { get; set; }
        //label have a juste one domaine(single instance of domaine)
        public CategorieModel Categories { get; set; }
    }
}
