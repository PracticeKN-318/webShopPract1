using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.Models;

namespace webShop.ViewModels
{
    public class SearchCarViewModel
    {
        public IEnumerable<Car> searchCars { get; set; }

        public string searchHead { get; set; }
    }
}
