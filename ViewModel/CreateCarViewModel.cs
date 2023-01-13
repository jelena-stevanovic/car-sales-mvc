using CarsSelling.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsSelling.ViewModel
{
    public class CreateCarViewModel
    {
        public Car car { get; set; }

        [DisplayName("Image")]
        [Required(ErrorMessage = "ImageRequired")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Power")]
        [Required(ErrorMessage = "PowerRequired")]
        public int? Power { get; set; }

        [DisplayName("Year")]
        [Required(ErrorMessage = "YearRequired")]
        public int? Year { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "PriceRequired")]
        public decimal? Price { get; set; }

        [DisplayName("Displacement")]
        [Required(ErrorMessage = "DisplacementRequired")]
        public decimal? Displacement { get; set; }


        public IEnumerable<SelectListItem> FuelTypes { get; internal set; }

        public IEnumerable<SelectListItem> Makes { get; set; }

        public IEnumerable<SelectListItem> BodyTypes { get; set; }
    }
}

