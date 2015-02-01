using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AteaHomeProject.AppCode.Repositories;
using AteaHomeProject.ViewModels;

namespace AteaHomeProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Message()
        {
            var model = new ConsoleMessageModel();
            model.ConsoleMessages = ConsoleMessageRepository.GetAll();
                
            return View(model);
        }

    }
}
