using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using webShop.Data.interfaces;
using webShop.Data.Models;
using webShop.ViewModels;

namespace webShop.Controllers
{
    public class CarsController : Controller
    {
        //тест комент
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Електромобілі")).OrderBy(i => i.id);
                    currCategory = "Електромобілі";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Класичні автомобілі")).OrderBy(i => i.id);
                    currCategory = "Класичні автомобілі";
                }

            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з авто";


            return View(carObj);
        }

        [Route("Cars/SearchCar")]
        [Route("Cars/SearchCar/{Search}")]
        public ViewResult SearchCar(string Search)
        {
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (!string.IsNullOrEmpty(Search))
            {
                cars = _allCars.Cars.Where(i => i.name.Equals(Search));
                currCategory = "Результат пошуку";
            }
            if(cars == null)
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
                currCategory = "Атомобілі з назвою - " + Search + " відсутні!";
            }

            var searchCars = new SearchCarViewModel
            {
                searchCars = cars,
                searchHead = currCategory
            };

            ViewBag.Title = "Результат пошуку автомобілів";
            return View(searchCars);
        }
    }
}
