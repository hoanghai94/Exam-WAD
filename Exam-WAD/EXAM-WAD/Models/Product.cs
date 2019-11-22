using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAM_WAD.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
        public int UnitOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category Category { get; set; }
    }
}