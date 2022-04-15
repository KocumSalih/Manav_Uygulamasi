using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.Entities
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public int DistrictId { get; set; }
        public string Phone { get; set; }


        //       [CustomerId] [int] IDENTITY(1,1) NOT NULL,

        //   [FirstName] [nvarchar] (40) NOT NULL,

        //    [LastName] [nvarchar] (40) NOT NULL,

        //     [City] [nvarchar] (20) NULL,
        //[Region] [nvarchar] (15) NULL,
        //[Phone] [nvarchar] (24) NULL,
    }
}
