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
            return View(listCharge);
        }
        [HttpPost]
        public ActionResult consulter(int id)
        {
            //ChargeAffaire.getStaticListComptes(id);
            List<Compte> listC = ListCharges.list[id].listComptes;
            var tuple = (ListCharges.list[id].intitule,listC);
            return Json(tuple);
        }

        [HttpPost]
        public ActionResult Ajouter(int id, int codeAgence,int numCompte, string intitule)
        {
            ListCharges.list[id].addCompte(numCompte, codeAgence, intitule);
            return RedirectToAction("ListCharge");
        }

        public ActionResult Supprimer(int id,int idCompte)
        {
            ListCharges.list[id].listComptes.RemoveAt(idCompte);
            ListCharges.list[id].updateIds(idCompte);
            return RedirectToAction("ListCharge");
        }

        [HttpPost]
        public ActionResult Remplacant(int id)
        {
            List<ChargeAffaire> list = ListCharges.list.FindAll(x => x.id != id);
            return Json(list);
        }

        [HttpPost]
        public ActionResult Affecter(int id,int idCompte,int idCharge)
        {
            Compte cpt = ListCharges.list[id].listComptes[idCompte];
            ListCharges.list[idCharge].addCompte(cpt.numeroCompte,cpt.codeAgence,cpt.intitule);
            ListCharges.list[id].listComptes.RemoveAt(idCompte);
            ListCharges.list[id].updateIds(idCompte);
            return RedirectToAction("ListCharge");
            //return Content($"account: {idCompte},  old: {id},  new: {idCharge}");
        }

         [HttpPost]
        public ActionResult CheckComptes(int id)
        {
            List<Compte> list = ListCharges.list[id].listComptes.FindAll(x => x.interimaire.id == id);
            return Json(list);
        }
        
        [HttpPost]
        public ActionResult SelectInterim(int id)
        {
            List<ChargeAffaire> list = ListCharges.list.FindAll(x => x.id != id);
            return Json(list);
        }

        [HttpPost]
        public ActionResult Interimaire(int id,DateTime dateDeb,DateTime dateFin,int[] idsCompte,int idCharge)
        {
            return Content($"chargé: {ListCharges.list[id].intitule}\nDebut: {dateDeb.Date}\nFin: {dateFin.Date}\nLength: {idsCompte.Length}\nIntérimaire: {ListCharges.list[idCharge].intitule}");
        }

    }
}