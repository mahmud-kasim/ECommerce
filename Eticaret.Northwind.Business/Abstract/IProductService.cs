using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.Business.Abstract
{
    public interface IProductService
    {// Burda gene yapılacak işlemler sadece tanımları interface burası
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
