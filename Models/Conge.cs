using System;
using System.ComponentModel.DataAnnotations;

namespace CentreAffaire.Models
{
    public class Conge
    {
        [DataType(DataType.Date)]
        public DateTime debut { get; set; }

        [DataType(DataType.Date)]
        public DateTime fin { get; set; }

        public string etat { get; set; }
        public Conge()
        {
            etat = "Actif";
        }
        public void setDate(DateTime d,DateTime f)
        {
            debut = d;
            fin = f;
            etat = "Conge";
        }

    }
}