using System;
using System.Collections.Generic;

/* 
    A1: ajout compte
    S1: suppression compte
    AF: affectation
    I: ajout interimaire
    C: ajout conge
    CN: modification conge
 */

namespace CentreAffaire.Models
{
    public static class ListLog
    {
        public static List<Log> list = new List<Log>();

        public static void ajoutLog(int idCharge,int ca,int nc)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "A1",
                message = $"A1-{now}-{idCharge}-{ca}-{nc}"
            };
            list.Add(log);
        }
        public static void suppressionLog(int idCharge,int id)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "S1",
                message = $"S1-{now}-{idCharge}-{id}"
            };
            list.Add(log);
        }
        public static void affectationLog(int idCharge,int id,int nIdCharge)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "AF",
                message = $"AF-{now}-{idCharge}-{nIdCharge}-{id}"
            };
            list.Add(log);
        }
        public static void interimaireLog(int idCharge,int id,int idInterim)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "I",
                message = $"I-{now}-{idCharge}-{idInterim}-{id}"
            };
            list.Add(log);
        }
        public static void congeLog(int idCharge,DateTime deb, DateTime fin)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "C",
                message = $"C-{now}-{idCharge}-{deb}-{fin}"
            };
            list.Add(log);
        }
        public static void congeModifLog(int idCharge,DateTime deb, DateTime fin,DateTime ndeb, DateTime nfin)
        {
            DateTime now = DateTime.Now;
            Log log = new Log() {
                id = list.Count,
                code = "CN",
                message = $"CN-{now}-{idCharge}-{deb}-{fin}-{ndeb}-{nfin}"
            };
            list.Add(log);
        }
    }
}