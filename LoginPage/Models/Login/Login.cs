using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models.Login
{
    public class Login

    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "*Reqired")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Reqired")]
        public string Password { get; set; }
    }
}
