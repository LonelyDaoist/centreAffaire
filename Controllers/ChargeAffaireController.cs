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

    }
}