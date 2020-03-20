using PharmacyCL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyCL
{
    public interface IPharmacyAssets
    {
        public IEnumerable<Pharm> GetAll();
        public Pharm GetById();


        void Add(Pharm pharmassets);
        string GetUserId(int id);
        string GetMedicineId(int id);
        string GetPrescriptionId(int id);

        PharmacyBranch GetLocation(int id);
    }
}
