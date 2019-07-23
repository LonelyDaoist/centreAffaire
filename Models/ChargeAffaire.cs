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
        public String intitule { get; set; }

        public List<Compte> listComptes = new List<Compte>();

        public Conge conge = new Conge();

        public void addCompte(int numC, int codeA, string intit)
        {
            listComptes.Add(new Compte(){id=listComptes.Count,numeroCompte=numC, codeAgence=codeA,intitule=intit, charge=new employee(this.id,this.intitule),interimaire=new employee(this.id,this.intitule)});
        }

        public void updateIds(int n)
        {
            for (int i=n;i<listComptes.Count;i++)
            {
                listComptes[i].id--;
            }
        }

        /*
        public static void getStaticListComptes(int _id)
        {   
            Random rnd = new Random();
            ListCharges.list[_id].listComptes.Clear();
            ListCharges.list[_id].addCompte(rnd.Next(1000,10000),rnd.Next(1,100),"A."+ListCharges.list[_id].Intitule);
            ListCharges.list[_id].addCompte(rnd.Next(1000,10000),rnd.Next(1,100),"B."+ListCharges.list[_id].Intitule);
            ListCharges.list[_id].addCompte(rnd.Next(1000,10000),rnd.Next(1,100),"C."+ListCharges.list[_id].Intitule);
            ListCharges.list[_id].addCompte(rnd.Next(1000,10000),rnd.Next(1,100),"D."+ListCharges.list[_id].Intitule);
        }
        */

    }
}