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
            var model = new MessageViewModel()
            {
                Date = DateTime.Now
            };
            model.MessageTitle = "This is the new message I can awesomely set";
            model.MessageVersionNumber = 5;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Submit(MessageViewModel model )
        {
            return View("Index", model);
        }

    }
}