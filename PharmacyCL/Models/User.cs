using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacyCL.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, StringLength(10)]
        public string UserName { get; set; }
        [Required, StringLength(25)]
        public string Email { get; set; }
        [Required, StringLength(15)]
        public string Password { get; set; }
        public Prescription Prescription { get; set; }

    }
}
