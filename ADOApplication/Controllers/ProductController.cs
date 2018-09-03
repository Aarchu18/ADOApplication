using ADOApplication.Models;
using ADOModel;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ADOApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IDBOperations dBOperations;
        public ProductController()
        {
            dBOperations = new DBOperations();
        }

        public ActionResult Index()
        {
          return View(dBOperations.GetProducts());
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product addProduct)
        {
            dBOperations.AddProduct(addProduct);
            return RedirectToAction("Index");
        }
        public IActionResult EditProduct(int id)
        {
            Product updateProduct = dBOperations.GetProductId(id);
            return View(updateProduct);
        }
        [HttpPost]
        public IActionResult EditProduct(Product updateProduct)
        {
            dBOperations.UpdateProduct(updateProduct);
            return RedirectToAction("Index");

        }
        public IActionResult Detailproduct(int id)
        {
            Product detailProduct = dBOperations.GetProductId(id);
            return View(detailProduct);
        }

        [HttpPost]
        public IActionResult SearchProduct(SearchModel searchModel)
        {
            IEnumerable<Product> productSearch = dBOperations.GetProducts();
            if (searchModel.MaxRange == 0)
            {
                searchModel.MaxRange = 999999999;
            }
            if (searchModel.SearchText == null)
            {
                searchModel.SearchText = "";
            }
            if (searchModel.ProductCategoryId != 0)
            {
                productSearch = (from s in productSearch
                                 where s.ProductName.ToUpper().Contains(searchModel.SearchText.ToUpper())
                               && (s.ProductPrice >= searchModel.MinRange && s.ProductPrice <= searchModel.MaxRange)
                               && (s.ProductCategoryId.ToString().Contains(searchModel.ProductCategoryId.ToString()))
                              select s).ToList();
            }
            else
            {
                productSearch = (from s in productSearch
                              where s.ProductName.ToUpper().Contains(searchModel.SearchText.ToUpper())
                               && (s.ProductPrice >= searchModel.MinRange && s.ProductPrice <= searchModel.MaxRange)
                              select s).ToList();
            }

            return View(productSearch);
        }

        public IActionResult Deleteproduct(int id)
        {
           dBOperations.DeleteProductId(id);
            return RedirectToAction("Index");
        }



    }
}
