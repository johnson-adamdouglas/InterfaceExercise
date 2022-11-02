using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Name { get; set; }
        public int BedLength { get; set; }
        public int TowingCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int SeatingCapacity { get; set; }
        public bool IsAWD { get; set; }
        public string TaxID { get; set; }
        public string CorporateType { get; set; }
    }
}
