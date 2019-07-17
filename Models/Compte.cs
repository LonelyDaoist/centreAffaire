using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentreAffaire.Models
{
    public class Compte
    {
        public int id { get; set; }
        public int numeroCompte { get; set; }
        public int codeAgence { get; set; }
        public String intitule { get; set; }
        public string chargeIntitule { get; set; }
        public string interimaireIntitule { get; set; }
        
    }
}