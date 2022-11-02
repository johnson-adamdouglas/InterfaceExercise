using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string TaxID { get; set; }
        public string CorporateType { get; set; }
    }
}
