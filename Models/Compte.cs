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
        public ChargeAffaire charge { get; set; }
        public ChargeAffaire interimaire { get; set; }
        

        public List<Compte> getListComptes()
        {
            ChargeAffaire ca1 = new ChargeAffaire() { id = 1, matricule = 123456, Intitule = "Mustapha Belhaj" };
            ChargeAffaire ca2 = new ChargeAffaire() { id = 2, matricule = 456789, Intitule = "Ahmed Ben Chrifa" };
            ChargeAffaire ca3 = new ChargeAffaire() { id = 3, matricule = 124578, Intitule = "Mongia Chérif" };
            ChargeAffaire ca4 = new ChargeAffaire() { id = 4, matricule = 713641, Intitule = "Ghassen Ghassen" };
            Compte c1 = new Compte() { id = 1, numeroCompte = 1234, codeAgence = 919, intitule = "Ahmed ben Cherif", charge = ca1, interimaire = ca1 };
            Compte c2 = new Compte() { id = 2, numeroCompte = 4321, codeAgence = 919, intitule = "Ghassen ghassen", charge = ca2, interimaire = ca2 };
            Compte c3 = new Compte() { id = 3, numeroCompte = 4567, codeAgence = 919, intitule = "Mustapha Belhaj", charge = ca3, interimaire = ca3 };
            Compte c4 = new Compte() { id = 4, numeroCompte = 9876, codeAgence = 919, intitule = "Mongia Cherif", charge = ca4, interimaire = ca4 };
            List<Compte> listc = new List<Compte>();
            listc.Add(c1); listc.Add(c2); listc.Add(c3); listc.Add(c4);
            return listc;
        }

    }
}