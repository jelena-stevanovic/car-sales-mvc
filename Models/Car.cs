using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsSelling.Models
{
    public class Car
    {
        public int Id { get; set; }

        ////[DisplayName("Model")]
        [Required(ErrorMessage = "ModelRequired")]
        public string Model { get; set; }

        public string ImagePath { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.#}")]
        [Required]
        public int Power { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.#}")]
        [Required]
        public int Year { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [Column(TypeName="decimal(18,4)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Displacement { get; set; }

        [DisplayName("Description")]
        [StringLength(400, MinimumLength = 30)]
        [Required(ErrorMessage = "DescriptionRequired")]
        public string Description { get; set; }

        [DisplayName("Contact")]
        [StringLength(15, MinimumLength = 7)]
        [Required(ErrorMessage = "ContactRequired")]
        public string Contact { get; set; }

        [DisplayName("Body")]
        [Required(ErrorMessage = "Please enter body type")]
        public int BodyTypeId { get; set; }

        [DisplayName("Fuel")]
        [Required(ErrorMessage = "Please enter fuel type")]
        public int FuelTypeId { get; set; }

        [DisplayName("Make")]
        [Required(ErrorMessage = "Please enter make")]
        public int MakeId { get; set; }
        public FuelType FuelType { get; set; }
        public Make Make { get; set; }
        public BodyType BodyType { get; set; }
    }
}

