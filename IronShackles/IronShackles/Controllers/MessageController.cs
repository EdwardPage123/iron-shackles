using IronShackles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IronShackles.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Index()
        {
            var model = new MessageViewModel() { MessageTitle = "Let's see if this works properly", Date = DateTime.Now };
            return View(model);
        }
    }
}