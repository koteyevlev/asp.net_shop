using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars: IAllCars
    {
        private MockCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name="Tesla A", Available = true, ShortDescription = "", LongDescription = "",
                        Price = 45000, IsFavourite = true, ImageURL="", Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name="Tesla C", Available = false, ShortDescription = "", LongDescription = "",
                        Price = 54000, IsFavourite = true, ImageURL="", Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name="Lada Granta", Available = true, ShortDescription = "", LongDescription = "",
                        Price = 4000, IsFavourite = false, ImageURL="", Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }

        public IEnumerable<Car> GetFavouriteCars { get; set; }
        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}