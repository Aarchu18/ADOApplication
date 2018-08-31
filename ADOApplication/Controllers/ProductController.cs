using ADOModel;
using DAL;
using Microsoft.AspNetCore.Mvc;



namespace ADOApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IDBOperations dBOperations;
        public ProductController()
        {
            dBOperations = new DBOperations();
        }

        //public ActionResult Index()
        //{
        //    return View(dBOperations.GetProducts());
        //}

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product productbj)
        {
            dBOperations.AddProduct(productbj);
            return RedirectToAction("Index");
        }

        //public ActionResult Details(int id)
        //{
        //    return View(dBOperations.GetProductById(id));
        //}
        //public ActionResult Edit(int id)
        //{
        //    return View(dBOperations.GetProductById(id));
        //}

        //[HttpPost]
        //public ActionResult Edit(Product product)
        //{
        //    dBOperations.UpdateProduct(product);
        //    return RedirectToAction("Index");
        //}
    }
}
