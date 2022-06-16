using System.Collections.Generic;
using webShop.Data.Models;

namespace webShop.ViewModels
{
    public class CarsListViewModel {

        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
