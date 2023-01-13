using CarsSelling.Models;
using CarsSelling.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq;

namespace CarsSelling.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IFuelTypeRepository _fuelTypeRepository;
        private readonly IMakeRepository _makeRepository;
        private readonly IBodyTypeRepository _bodyTypeRepository;

        public IWebHostEnvironment WebHostEnvironment { get; }

        public CarController(ICarRepository carRepository, IFuelTypeRepository fuelTypeRepository,
            IMakeRepository makeRepository, IBodyTypeRepository bodyTypeRepository, IWebHostEnvironment webHostEnvironment)
        {
            _carRepository = carRepository;
            _fuelTypeRepository = fuelTypeRepository;
            _makeRepository = makeRepository;
            _bodyTypeRepository = bodyTypeRepository;
            WebHostEnvironment = webHostEnvironment;
        }
        // GET: CarController
        public ActionResult Index()
        {

            return View();
        }

        // GET: CarController/Details/5
        public IActionResult Details(int id)
        {
            CarDetailsViewModel carDetailsViewModel = new CarDetailsViewModel();
            carDetailsViewModel.Car = _carRepository.GetCarById(id);
            if (carDetailsViewModel == null)
            {
                return NotFound();
            }
            return View(carDetailsViewModel);
        }

        // GET: CarController/AddCar
        public ActionResult AddCar()
        {
            CreateCarViewModel carViewModel = new CreateCarViewModel();

            carViewModel.Makes = _makeRepository.AllMakes.Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });

            carViewModel.FuelTypes = _fuelTypeRepository.AllFuelTypes.Select(ft => new SelectListItem()
            {
                Value = ft.Id.ToString(),
                Text = ft.Name
            });

            carViewModel.BodyTypes = _bodyTypeRepository.AllBodyTypes.Select(bt => new SelectListItem()
            {
                Value = bt.Id.ToString(),
                Text = bt.Name
            });
            return View(carViewModel);
        }

        [HttpPost]
        public ActionResult AddCar(CreateCarViewModel carViewModel)
        {
            if (ModelState.IsValid)
            {
                Car car = carViewModel.car;

                string imageUploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "ImageUpload");
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(carViewModel.ImageFile.FileName);
                string filePath = Path.Combine(imageUploadDir, fileName);
                carViewModel.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                car.ImagePath = "~/ImageUpload/" + fileName;
                car.Year = (int)carViewModel.Year;
                car.Price = (decimal)carViewModel.Price;
                car.Power = (int)carViewModel.Power;
                car.Displacement = (decimal)carViewModel.Displacement;

                _carRepository.AddCar(carViewModel.car);

                car.FuelType = _fuelTypeRepository.AllFuelTypes.FirstOrDefault(ft => ft.Id == car.FuelTypeId);
                car.Make = _makeRepository.AllMakes.FirstOrDefault(m => m.Id == car.MakeId);
                car.BodyType = _bodyTypeRepository.AllBodyTypes.FirstOrDefault(bt => bt.Id == car.BodyTypeId);

                CarDetailsViewModel detailsViewModel = new CarDetailsViewModel();
                detailsViewModel.AfterCreation = true;
                detailsViewModel.Car = car;
                return View("Details", detailsViewModel);
            }

            return View(carViewModel);
        }
       
    }
}
