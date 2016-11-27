using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WrapperExtensions;

namespace pdxMaps.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository _repository;

        public HomeController()
        {
            this._repository = new Repository(new ModelStateWrapper(this.ModelState));
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}