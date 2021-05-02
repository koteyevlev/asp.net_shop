using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }

        public ViewResult List()
        {
            CarsListViewModel carsListViewModel = new CarsListViewModel();
            carsListViewModel.AllCars = _allCars.Cars;
            carsListViewModel.CarCategory = "Cars";
            return View(carsListViewModel);
        }
        
        public ViewResult ListBad()
        {
            ViewBag.Title = "Page with cars";
            ViewBag.Category = "Some Category";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}