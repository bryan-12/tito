using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pruebagit.Controllers
{
    public class PersonaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
