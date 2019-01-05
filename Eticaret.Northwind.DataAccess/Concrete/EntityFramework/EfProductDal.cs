using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Core.DataAccess.EntityFramework;
using Eticaret.Northwind.DataAccess.Abstract;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
