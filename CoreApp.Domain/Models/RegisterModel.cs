using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApp.Domain.Models
{
    public class RegisterModel
    {
        [Required]
        public string ReferenceCode { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
