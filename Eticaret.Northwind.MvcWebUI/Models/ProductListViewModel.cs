using Eticaret.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; } // Product classından burda kendime bir Products Modeli 
        //oluşturdum htmlden bunu çekiyorum forEach ile 
    }
}
