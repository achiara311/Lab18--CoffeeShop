using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18CoffeeShop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(30, ErrorMessage = "Must be less than 30 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Not a cool nickname apparently.")]
        [StringLength(20, ErrorMessage = "Not a cool nickname apparently.")]
        public string NickName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Must be less than 30 characters.")]
        [RegularExpression("\b[\\w\\.-]+@[\\w\\.-]+\\.\\w{2,4}\b/", ErrorMessage = "Must have @ symbol.")]
        public string Email { get; set; }

        public string Password { get; set; }


        [RegularExpression("[(]?\\d{3}[-.)]?[ ]?\\d{3}[-.]?\\d{4}\b", ErrorMessage = "Must be 10 numbers only.")]
        public int PhoneNumber { get; set; }

        [Required]
        [RegularExpression("[0-9]{5}(-[0-9]{4})?", ErrorMessage = "Too many numbers")]
        public int ZipCode { get; set; }

    }
}
