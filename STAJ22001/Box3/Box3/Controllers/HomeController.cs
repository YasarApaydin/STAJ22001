using Box3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace Box3.Controllers
{
    
    public class HomeController : Controller
    {

        
     
        
        public IActionResult Index()
        {
            return View();
        }

        
       

     
        
        public IActionResult Privacy()
        {
            
            return View();
        }

    
    }
}
