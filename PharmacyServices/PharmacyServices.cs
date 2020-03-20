using PharmacyCL;
using PharmacyCL.Models;
using System;
using System.Collections.Generic;

namespace PharmacyServices
{
    public class PharmacyServices :IPharmacyAssets
    {
        private Pharm _appcontext;
        public PharmacyServices(Pharm assets)
        {
            _appcontext = assets;
        } 

        public void Add(Pharm pharmassets)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pharm> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pharm GetById()
        {
            throw new NotImplementedException();
        }

        public PharmacyBranch GetLocation(int id)
        {
            throw new NotImplementedException();
        }

        public string GetMedicineId(int id)
        {
            throw new NotImplementedException();
        }

        public string GetPrescriptionId(int id)
        {
            throw new NotImplementedException();
        }

        public string GetUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
