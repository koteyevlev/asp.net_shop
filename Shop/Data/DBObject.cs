using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent appDBContent)
        {
            if (!appDBContent.Category.Any())
            {
                appDBContent.Category.AddRange(Categories.Select(category => category.Value));
            }
            if (!appDBContent.Car.Any())
            {
                appDBContent.AddRange(
                    new Car
                    {
                        Name = "Tesla A",
                        Available = true,
                        ShortDescription = "",
                        LongDescription = "",
                        Price = 45000,
                        IsFavourite = true,
                        ImageURL = "/img/tesla.png",
                        Category = category["Electra Cars"]
                    },
                        new Car
                        {
                            Name = "Tesla C",
                            Available = false,
                            ShortDescription = "",
                            LongDescription = "",
                            Price = 54000,
                            IsFavourite = true,
                            ImageURL = "/img/tesla.png",
                            Category = category["Electra Cars"]
                        },
                        new Car
                        {
                            Name = "Lada Granta",
                            Available = true,
                            ShortDescription = "",
                            LongDescription = "",
                            Price = 4000,
                            IsFavourite = false,
                            ImageURL = "/img/granta.png",
                            Category = category["Classic Cars"]
                        }
                );
                appDBContent.SaveChanges();
            }
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories{
            get
            {
                if (category is null)
                {
                    var tmpList = new Category[]
                    {
                        new Category {CategoryName = "Electra Cars", Description = "Ecologically clean cars"},
                        new Category {CategoryName = "Classic Cars", Description = "Old fashioned cars"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (var element in tmpList)
                    {
                        category.Add(element.CategoryName, element);
                    }
                }
                return category;
            }
        }
    }
}
