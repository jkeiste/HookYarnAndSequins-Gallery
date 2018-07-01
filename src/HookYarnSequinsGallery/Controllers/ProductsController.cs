using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HookYarnSequinsGallery.Models;
using HookYarnSequinsGallery.Data;

namespace HookYarnSequinsGallery.Controllers
{
    public class ProductsController : Controller
    {
        private ProductRepository _productRepository = null;

        public ProductsController()
        {
            _productRepository = new ProductRepository();
        }

        public ActionResult Index()
        {
            var products = _productRepository.GetProducts();

            return View(products);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var product = _productRepository.GetProduct(id.Value);

            return View(product);           
        }
    }
}