using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDbContent;

        public CarRepository(AppDBContent appDBContent)
        {
            appDbContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDbContent.Car.Include(car => car.Category);

        public IEnumerable<Car> GetFavouriteCars => appDbContent.Car.Where(car => car.IsFavourite).Include(car => car.Category);

        public Car GetObjectCar(int carId) => appDbContent.Car.FirstOrDefault(car => car.Id == carId);
    }
}
