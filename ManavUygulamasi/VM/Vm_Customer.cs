using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.VM
{
    public class Vm_Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }

    }
}
