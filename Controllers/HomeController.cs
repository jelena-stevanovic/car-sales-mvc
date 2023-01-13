using CarsSelling.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CarsSelling.Controllers
{
    public class HomeController : Controller
    {
        public IStringLocalizer<Resource> localizer;
        private readonly ILogger<HomeController> _logger;
        private readonly ICarRepository _carRepository;

        public HomeController(ILogger<HomeController> logger, ICarRepository carRepository, IStringLocalizer<Resource> localizer)
        {
            _logger = logger;
            _carRepository = carRepository;
            this.localizer = localizer;
        }

        public IActionResult SetCulture(string culture, string sourceUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                }
            );
            return Redirect(sourceUrl);
        }

        public IActionResult Index()
        {

            
            IEnumerable<Car> cars = _carRepository.AllCars;
            return View(cars);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult ConfirmDelete(int id)
        {
            var car = _carRepository.GetCarById(id);
            return View(car);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int id)
        {
            _carRepository.DeleteCar(id);

            TempData["deletionMessage"] = localizer["SuccessfulDelete"].ToString();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
