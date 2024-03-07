using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using home_made_harmony_online.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using home_made_harmony_online.Models;

namespace home_made_harmony_online.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult sellerLogin()
        {
            SellerModel newSeller = new SellerModel();
            newSeller.fName = "orzalena";
            newSeller.lName = "elelqa";
            newSeller.phoneNumber = "054721474";


            return View("sellerLogin", newSeller);// return the page. 
        }

        public IActionResult getSellerForm()
        {
            return View("sellerForm");
        }
   
    }
}
