using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using One.Data;
using One.Models;

namespace One.Controllers
{
    public class ProductController : Controller
    {
        private readonly  Db _context;
        public ProductController(Db context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pList = _context.tblproducts.ToList();
            return View(pList);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try {
            if (ModelState.IsValid)
            {
                    if (product.Id == 0) { 
                _context.tblproducts.Add(product);
                _context.SaveChanges();
            }
                }
                else
                {
                    _context.Entry(product).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}