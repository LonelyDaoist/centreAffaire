using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentreAffaire.Models
{
    public struct employee
        {
            public string intitule { get; set; }
            public int id { get; set; }
            public employee(int _id,string _intitule)
            {
                id = _id;
                intitule = _intitule;
            }
        }
        
    public class Compte
    {
        public int id { get; set; }
        public int numeroCompte { get; set; }
        public int codeAgence { get; set; }
        public String intitule { get; set; }
        public employee charge = new employee();
        public employee interimaire;



        
    }
}