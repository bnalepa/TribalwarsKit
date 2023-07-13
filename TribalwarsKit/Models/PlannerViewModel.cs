using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TribalwarsKit.Models
{
    public class PlannerViewModel
    {
        [Required]
        [StringLength(500, MinimumLength = 7, ErrorMessage = "Podaj przynajmniej jedne coordy")]
        public string AttackCoords { get; set; }

        //[Phone(ErrorMessage = "Invalid phone number")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "Wrong phone number")]
        //[StringLength(12, MinimumLength = 9, ErrorMessage = "Phone number is too short!")]
        //public string AttackType { get; set;}

        //[Required]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "Last name is too short!")]
        //public string LastName { get; set; } = string.Empty;

    }
}
