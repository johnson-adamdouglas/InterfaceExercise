using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasSunroof { get; set; }
        public int SeatingCapacity { get; set; }
        public bool IsAWD { get; set; }

        public int NumberOfDoors { get; set; }
        public string BodyStyle { get; set; }

        public string TaxID { get; set; }
        public string CorporateType { get; set; }
    }
    
}
