using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.Models;

namespace webShop.Data
{
    public class DBObjects
    {
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                        new Category {categoryName = "Класичні автомобілі", desc = "Машини з двигуном внутрішнього згоряння" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var item in list)
                        category.Add(item.categoryName, item);
                }

                return category;
            }
        }

        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Швидкий автомобіль",
                        longDesc = "Красивий, швидкий та зручний автомобіль компанії Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Електромобілі"]
                    },
                 new Car
                 {
                     name = "Ford Fiesta",
                     shortDesc = "Тихий і спокійний",
                     longDesc = "Зручний автомобіль для місцевого життя",
                     img = "/img/ford.jpg",
                     price = 11000,
                     isFavourite = false,
                     available = true,
                     Category = Categories["Класичні автомобілі"]
                 },
                  new Car
                  {
                      name = "BMW M3",
                      shortDesc = "Зухвалий і стильний",
                      longDesc = "Автомобіль для дрифту і шашок по місту",
                      img = "/img/bmw.jpg",
                      price = 65000,
                      isFavourite = true,
                      available = true,
                      Category = Categories["Класичні автомобілі"]
                  },
                   new Car
                   {
                       name = "Mercedes C Class",
                       shortDesc = "Зручний і великий",
                       longDesc = "",
                       img = "/img/mers.jpg",
                       price = 40000,
                       isFavourite = false,
                       available = false,
                       Category = Categories["Класичні автомобілі"]
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
                        Category = Categories["Електромобілі"]
                    }
                    );
            }

            content.SaveChanges();
        }
    }
}
