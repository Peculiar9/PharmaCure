namespace PharmacyCL.Models
{
    public class PharmacyBranch 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual PharmacyBranch Location { get; set; }
    }
}