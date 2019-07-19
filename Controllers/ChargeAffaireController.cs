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
            return Json(listC);
        }

        [HttpPost]
        public ActionResult Ajouter(int id, int codeAgence,int numCompte, string intitule)
        {
            ListCharges.list[id].addCompte(numCompte, codeAgence, intitule);
            return RedirectToAction("ListCharge");
        }

        [HttpPost]
        public ActionResult CheckCOmptes(int id)
        {
            List<Compte> list = ListCharges.list[id].listComptes;
            return Json(list);
        }
        
        [HttpPost]
        public ActionResult checkInterim(int id)
        {
            List<ChargeAffaire> list = ListCharges.list.FindAll(x => x.id != id);
            return Json(list);
        }

        public ActionResult Supprimer(int id,int idCompte)
        {
            // must also update the ids for future deletes
            ListCharges.list[id].listComptes.RemoveAt(idCompte);
            return RedirectToAction("ListCharge");
            //return Content($"Compte: {idCompte} Charge: {id}");
        }

    }
}