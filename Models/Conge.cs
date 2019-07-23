using System;
using System.ComponentModel.DataAnnotations;

namespace CentreAffaire.Models
{
    public class Conge
    {
        [DataType(DataType.Date)]
        DateTime debut { get; set; }

        [DataType(DataType.Date)]
        DateTime fin { get; set; }

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