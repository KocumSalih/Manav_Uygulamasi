using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.Entities
{
    class Product
	{
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }


        //ProductId int primary key identity(1,1) not null,
        //ProductName nvarchar(40) not null,
        //CategoryId int foreign key references Categories(CategoryId),
        //QuantityPerUnit nvarchar(20) null ,
        //UnitPrice money,
        //UnitsInStock smallint null,
        //UnitsOnOrder smallint null,
        //Discontinued bit not null

    }
}
