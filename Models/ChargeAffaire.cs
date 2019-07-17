using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentreAffaire.Models
{
    public class ChargeAffaire
    {
        public int id { get; set; }
        public int matricule { get; set; }
        public String Intitule { get; set; }


        public List<ChargeAffaire> getListCharge()
        {
            ChargeAffaire ca1 = new ChargeAffaire() { id = 1, matricule = 123456, Intitule = "Mustapha Belhaj" };
            ChargeAffaire ca2 = new ChargeAffaire() { id = 2, matricule = 456789, Intitule = "Ahmed Ben Chrifa" };
            ChargeAffaire ca3 = new ChargeAffaire() { id = 3, matricule = 124578, Intitule = "Mongia Chérif" };
            ChargeAffaire ca4 = new ChargeAffaire() { id = 4, matricule = 713641, Intitule = "Ghassen Ghassen" };
            List<ChargeAffaire> listCharge = new List<ChargeAffaire>();
            listCharge.Add(ca1); listCharge.Add(ca2); listCharge.Add(ca3); listCharge.Add(ca4);
            return listCharge;
        }
    }
}