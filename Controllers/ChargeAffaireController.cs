using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CentreAffaire.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace CentreAffaire.Controllers
{
    public class ChargeAffaireController : Controller
    {
        // GET: ChargeAffaire
        public ActionResult ListCharge()
        {
            //ListCharges.list.Clear();
            List<ChargeAffaire> listCharge = ListCharges.getStaticListCharge();
            return View();
        }
        [HttpGet]
        public ActionResult Consulter(int id)
        {
            List<Compte> listC = ListCharges.list[id].listComptes;
            return Json(listC);
        }

        [HttpGet]
        public string GetName(int id)
        {
            return ListCharges.list[id].intitule;
        }

        [HttpPost]
        public ActionResult Ajouter(int id, int codeAgence,int numCompte, string intitule)
        {
            ListLog.ajoutLog(id,codeAgence,numCompte);
            ListCharges.list[id].addCompte(numCompte, codeAgence, intitule);
            return RedirectToAction("ListCharge");
        }

        public ActionResult Supprimer(int id,int idCompte)
        {
            ListLog.suppressionLog(id,idCompte);
            ListCharges.list[id].listComptes.RemoveAt(idCompte);
            ListCharges.list[id].updateIds(idCompte);
            return RedirectToAction("ListCharge");
        }

        [HttpPost]
        public ActionResult Remplacant(int id)
        {
            List<ChargeAffaire> list = ListCharges.list.FindAll(x => (x.id != id) && (x.conge.etat == "Actif"));
            return Json(list);
        }

        [HttpPost]
        public ActionResult Affecter(int id,int idCompte,int idCharge)
        {
            ListLog.affectationLog(id,idCompte,idCharge);
            Compte cpt = ListCharges.list[id].listComptes[idCompte];
            ListCharges.list[idCharge].addCompte(cpt.numeroCompte,cpt.codeAgence,cpt.intitule);
            ListCharges.list[id].listComptes.RemoveAt(idCompte);
            ListCharges.list[id].updateIds(idCompte);
            return RedirectToAction("ListCharge");
        }

        [HttpGet]
        public ActionResult CheckComptes(int id)
        {
            List<Compte> list = ListCharges.list[id].listComptes;
            return Json(list);
        }
        
        [HttpGet]
        public ActionResult SelectInterim(int id)
        {
            List<ChargeAffaire> list = ListCharges.list.FindAll(x => (x.id != id) && (x.conge.etat == "Actif"));
            return Json(list);
        }

        public void Interimaire(int id,int[] idsCompte,int idCharge)
        {
            foreach (int c in idsCompte)
            {
                ListLog.interimaireLog(id,c,idCharge);
                ListCharges.list[id].listComptes[c].interimaire.id = idCharge;
                ListCharges.list[id].listComptes[c].interimaire.intitule = ListCharges.list[idCharge].intitule;
            }

            int n = ListCharges.list[id].listComptes.FindAll(x => x.charge.id == x.interimaire.id).Count;
            if (n == 0)
            {
                ListCharges.list[id].tousInterimaire = true;
            }
            
        }

        [HttpGet]
        public ActionResult GetActif()
        {
            var list = ListCharges.list.FindAll(x => x.conge.etat == "Actif");
            return Json(list);
        }
        [HttpGet]
        public ActionResult GetConge()
        {
            var list = ListCharges.list.FindAll(x => x.conge.etat == "Conge");
            return Json(list);
        }

        [HttpPost]
        public ActionResult UpdateConge(int id, DateTime dateDeb, DateTime dateFin)
        {
            ListLog.congeLog(id,dateDeb,dateFin);
            ListCharges.list[id].conge.setDate(dateDeb,dateFin);
            return RedirectToAction("ListCharge");
        }

        public ActionResult GetLog()
        {
            string s = "";
            var list = ListLog.list;
            foreach (var log in list)
            {
                s += log.message + "\n";
            }
            return Content(s);
        }

    }
}