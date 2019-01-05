using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Northwind.Business.Abstract;
using Eticaret.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {

            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
               
            };
            return View(model);
        }

    }
}
