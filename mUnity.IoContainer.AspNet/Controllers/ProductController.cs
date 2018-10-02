using mUnity.IoContainer.AspNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mUnity.IoContainer.AspNet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = _repository.GetAll();
            return View(products);
        }
    }
}