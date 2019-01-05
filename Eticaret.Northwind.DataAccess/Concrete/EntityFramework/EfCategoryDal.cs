using Eticaret.Core.DataAccess.EntityFramework;
using Eticaret.Northwind.DataAccess.Abstract;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}