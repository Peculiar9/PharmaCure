using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyCL.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyDesc { get; set; } //  What kind of company we are dealing with
        public virtual Company Location { get; set; }

    }
}
