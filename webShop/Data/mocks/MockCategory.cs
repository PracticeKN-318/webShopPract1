﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.interfaces;
using webShop.Data.Models;

namespace webShop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    
                    new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                     new Category {categoryName = "Класичні автомобілі", desc = "Машини з двигуном внутрішнього згоряння" }

                };
            }

        }
    }
}
