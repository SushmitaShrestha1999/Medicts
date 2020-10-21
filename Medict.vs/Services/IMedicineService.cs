using Medict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public interface IMedicineService
    {
        void AddMedicine(Medicine model);
        IEnumerable<Medicine> GetList();
        Medicine GetById(int id);
        void UpdateMedicine(Medicine model);
        void DeleteMedicineById(int id);
    }
}
