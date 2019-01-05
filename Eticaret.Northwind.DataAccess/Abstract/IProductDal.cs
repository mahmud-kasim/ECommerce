using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Core.DataAccess;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>  // Bu bir IEntitiyRepe dur diyorum
    {
        //Custom Operations
    }
}
