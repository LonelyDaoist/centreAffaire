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
            ChargeAffaire ca = new ChargeAffaire();
            List<ChargeAffaire> listCharge = ca.getListCharge();
            return View(listCharge);
        }
        [HttpPost]
        public ActionResult consulter(int id)
        {
            Compte c = new Compte();
            List<Compte> listC = c.getListComptes();
           /* ChargeAffaire ca = new ChargeAffaire();
            List<ChargeAffaire> listCharge = ca.getListCharge();*/
            return Json(listC);
        }
    }
}