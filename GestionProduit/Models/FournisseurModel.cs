using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class FournisseurModel
    {[Key]
        public string FournisseurId { get; set; }
        public string Nom { get; set; }
        public string Prenon { get; set; }
        public int Numtel { get; set; }
        public string LienFace { get; set; }
        public string Mail { get; set; }

    }
}
