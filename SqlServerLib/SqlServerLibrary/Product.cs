using System;
using System.Collections.Generic;
using System.Text;

namespace SqlServerLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public int VendorID { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; } = "Each";
        public string PhotoPath { get; set; }
        public string VendorCode { get; set; }


    }
}
