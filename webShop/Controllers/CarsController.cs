using Microsoft.AspNetCore.Mvc;
using webShop.Data.interfaces;
using webShop.ViewModels;

namespace webShop.Controllers
{
    public class CarsController : Controller{

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List() {
            ViewBag.Title = "Сторінка з авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобілі";


            return View(obj);
        }


    }
}
