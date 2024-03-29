﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.Models;

namespace webShop.Data.interfaces
{
    public interface IAllCars{

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        IEnumerable<Car> getSearchCar(string searchCar);
        Car getObjectCar(int carId);

    }
}
