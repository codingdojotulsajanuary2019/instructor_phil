using System;
using System.ComponentModel.DataAnnotations;

namespace DojoTemplate.Models
{
    public class Trail
    {
        [Key]
        public long TrailId {get; set;}

        [Required(ErrorMessage="Trail name is required")]
        public string Name {get; set;}

        [Required(ErrorMessage="Description is required")]
        [MinLength(10, ErrorMessage="Description must be at least 10 characters long.")]
        public string Description {get; set;}

        [Required(ErrorMessage="Length is required")]
        [RegularExpression(@"^[0-9]{1,4}(\.[0-9]{1})?$", ErrorMessage="Length must be the in the following format: xx.x")]
        public float? Length {get; set;}

        [Required(ErrorMessage="Elevation is required")]
        public int? Elevation {get; set;}

        [Required(ErrorMessage="Latitude is required")]
        [RegularExpression(@"^[0-9]{1,2}(\.[0-9]{4})$", ErrorMessage="Latitude must be the in the following format: xx.xxxx")]
        public float? Latitude {get; set;}

        [Required(ErrorMessage="Longitude is required")]
        [RegularExpression(@"^[0-9]{1,3}(\.[0-9]{4})$", ErrorMessage="Longitude must be the in the following format: xxx.xxxx")]
        public float? Longitude {get; set;}

        public DateTime CreatedAt {get; set;} = new DateTime();

        public DateTime UpdatedAt {get; set;} = new DateTime();
    }
}