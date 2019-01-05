using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Northwind.Business.Abstract;
using Eticaret.Northwind.DataAccess.Abstract;
using Eticaret.Northwind.Entities.Concrete;

namespace Eticaret.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {   // Burda gene işlemler yapılıyor class  burası
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
