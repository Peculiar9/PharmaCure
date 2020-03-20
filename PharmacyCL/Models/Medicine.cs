using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacyCL.Models
{
    public class Medicine
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime DeliveryTime { get; set; }
        [Required]
        public string Category { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public virtual PharmacyBranch Location { get; set; }//Foreign Key
        public string MedComposition { get; set; }
        
    }
}
