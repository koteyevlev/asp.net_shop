using System;
using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDbContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            appDbContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
