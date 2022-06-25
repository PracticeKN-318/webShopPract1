using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.interfaces;
using webShop.Data.Models;

namespace webShop.Data.mocks
{
    public class MockCars : IAllCars{

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Швидкий автомобіль",
                        longDesc = "Красивий, швидкий та зручний автомобіль компанії Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First() 
                },
                 new Car {
                     name = "Ford Fiesta",
                     shortDesc = "Тихий і спокійний",
                     longDesc = "Зручний автомобіль для місцевого життя",
                     img = "/img/ford.jpg",
                     price = 11000,
                     isFavourite = false,
                     available = true,
                     Category = _categoryCars.AllCategories.Last()
                 },
                  new Car {
                      name = "BMW M3",
                      shortDesc = "Зухвалий і стильний",
                      longDesc = "Автомобіль для дрифту і шашок по місту",
                      img = "/img/bmw.jpg",
                      price = 65000,
                      isFavourite = true,
                      available = true,
                      Category = _categoryCars.AllCategories.Last()
                  },
                   new Car {
                       name = "Mercedes C Class",
                       shortDesc = "Зручний і великий",
                       longDesc = "",
                       img = "/img/mers.jpg",
                       price = 40000,
                       isFavourite = false,
                       available = false,
                       Category = _categoryCars.AllCategories.Last()
                   },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Безшумний і економний",
                        longDesc = "Зручний автомобіль для тихої їзди",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };

            }

        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> getSearchCar(string searchCar)
        {
            throw new NotImplementedException();
        }
    }
}
