using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory:ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryName = "Electra Cars", Description = "Ecologically clean cars"},
                new Category {CategoryName = "Classic Cars", Description = "Old fashioned cars"}
            };
    }
}