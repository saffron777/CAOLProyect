using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CAOL.Web.Controllers
{
    public class DesempenhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}