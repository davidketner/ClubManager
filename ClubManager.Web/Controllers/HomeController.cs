using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClubManager.Web.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace ClubManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("cs/Mince")]
        [Route("bg/Moneta")]
        [Route("da/Mont")]
        [Route("de/Munzen")]
        [Route("el/Nomismata")]
        [Route("en/Coins")]
        [Route("es/Monedas")]
        [Route("fi/Kolikko")]
        [Route("fr/Pieces-de-monnaie")]
        [Route("hu/Erme")]
        [Route("it/Moneta")]
        [Route("ja/Koin")]
        [Route("nl/Muntstuk")]
        [Route("no/Mynt")]
        [Route("pl/Monety")]
        [Route("pt/Moedas")]
        [Route("ro/Moneda")]
        [Route("ru/Moneta")]
        [Route("sk/Mince")]
        [Route("sr/Kovanice")]
        [Route("sv/Mynt")]
        [Route("tr/Sikke")]
        public IActionResult Coins()
        {
            return View();
        }

        [Route("bg/Instruktsiya")]
        [Route("cs/Navod")]
        [Route("da/Instruktion")]
        [Route("de/Anweisungen")]
        [Route("el/Odigies")]
        [Route("en/Instructions")]
        [Route("es/Instrucciones")]
        [Route("fi/Opetus")]
        [Route("fr/Les-Instructions")]
        [Route("hu/Oktatas")]
        [Route("it/Istruzione")]
        [Route("ja/Setsumeisho")]
        [Route("nl/Instructie")]
        [Route("no/Instruksjon")]
        [Route("pl/Instrukcje")]
        [Route("pt/Instrucoes")]
        [Route("ro/Instructie")]
        [Route("ru/Instruktsiya")]
        [Route("sk/Navod")]
        [Route("sr/Uputstva")]
        [Route("sv/Instruktion")]
        [Route("tr/Talimat")]
        public IActionResult Manual()
        {
            return View();
        }

        [Route("bg/Liga")]
        [Route("cs/Ligy")]
        [Route("da/Liga")]
        [Route("de/Ligen")]
        [Route("el/Protathlimata")]
        [Route("en/Divisions")]
        [Route("es/Ligas")]
        [Route("fi/Liiga")]
        [Route("fr/Lieues")]
        [Route("hu/Liga")]
        [Route("it/Lega")]
        [Route("ja/Rigu")]
        [Route("nl/Liga")]
        [Route("no/Liga")]
        [Route("pl/Ligi")]
        [Route("pt/Ligas")]
        [Route("ro/Liga")]
        [Route("ru/Liga")]
        [Route("sk/Ligy")]
        [Route("sr/Leagues")]
        [Route("sv/Liga")]
        [Route("tr/Lig")]
        public IActionResult Leagues()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
