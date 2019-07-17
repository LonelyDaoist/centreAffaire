using System;
using System.Collections.Generic;

namespace CentreAffaire.Models
{
    public static class ListCharges
    {
        public static bool alreadyGotStaticInputs = false;
        public static List<ChargeAffaire> list = new List<ChargeAffaire>();

        public static void addCharge(int matr, string nom)
        {
            list.Add(new ChargeAffaire() {id=list.Count,matricule=matr, Intitule=nom});
        }

        public static List<ChargeAffaire> getStaticListCharge()
        {
            if (!alreadyGotStaticInputs)
            {
                alreadyGotStaticInputs = true;
                addCharge(23456, "Mustapha Belhaj");
                addCharge(456789, "Ahmed Ben Chrifa");
                addCharge(124578, "Mongia Chérif");
                addCharge(713641, "Ghassen Ghassen");
            }
            
            return list;
        }

    }
}