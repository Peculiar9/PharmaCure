using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyCL.Models
{
    public class Pharmacy 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual PharmacyBranch Location { get; set; }
        public string Status { get; set; } // Checks whether it is A major branch or a small one

    }
}
