using System.Collections.Generic;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}