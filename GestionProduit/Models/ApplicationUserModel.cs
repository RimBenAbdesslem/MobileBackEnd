using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduit.Models
{
    public class ApplicationUserModel
    {


        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        // public IList<string> Roles { get;  set; }
        public string Role { get; internal set; }
   //     public List<ParticipantToFormationModel> ParticipantToFormations { get; set; }
    }
}
