using Eticaret.Core.DataAccess;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}