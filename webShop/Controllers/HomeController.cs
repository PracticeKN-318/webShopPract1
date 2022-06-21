using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.interfaces;
using webShop.ViewModels;

namespace webShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;


        public HomeController(IAllCars carREp)
        {
            this._carRep = carREp;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
