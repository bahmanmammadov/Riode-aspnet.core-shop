using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult SimpleProduct()
        {
            return View();
        }
    }
}
