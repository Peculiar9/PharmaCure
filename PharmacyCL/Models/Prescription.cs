using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacyCL.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        [Required]
        public string PrescDesc { get; set; }
        [Required]
        public DateTime PrescDate { get; set; }

        public Medicine Medicine { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public PharmacyBranch Location { get; set; }
    }
}
