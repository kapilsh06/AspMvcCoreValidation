using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Validation_WithMVC.Attributes;

namespace Validation_WithMVC.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter name"), MaxLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter user name"), MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password"), MaxLength(15)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password"), MaxLength(15), Display(Name= "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter contact no"), MaxLength(10)]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Wrong contact number")]
        public string Contact{ get; set; }


        [Required(ErrorMessage = "Please enter country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter city")]
        public string City { get; set; }
       
        public string Gender { get; set; }

        //  [Required(ErrorMessage = "Please enter address")]
        //  public string address { get; set; }

        [ValidationCheckbox(ErrorMessage = "Please check terms"), Display(Name = "Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
