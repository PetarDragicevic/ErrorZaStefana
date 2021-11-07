using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KURS.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            string todeysDate = DateTime.Now.ToShortDateString();
            return Ok(todeysDate);
        }
    }
}
