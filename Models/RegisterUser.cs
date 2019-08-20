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

     
        public string NickName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Must be less than 30 characters.")]
        //[RegularExpression("\b[\\w\\.-]+@[\\w\\.-]+\\.\\w{2,4}\b/", ErrorMessage = "Must have @ symbol.")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        public string Password { get; set; }


        [RegularExpression(@"^[0-9]{3}[-]{1}[0-9]{3}[-]{1}[0-9]{4}$", ErrorMessage = "Must be 10 numbers only.")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("[0-9]{5}(-[0-9]{4})?", ErrorMessage = "Too many numbers")]
        public int ZipCode { get; set; }

    }
}
