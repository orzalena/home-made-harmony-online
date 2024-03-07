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

    public class CustomerController : Controller
    {
        public IActionResult showCustomerDetails()
        {
            //create a new customer obj and send it to page
            CustomerModel newCustomer = new CustomerModel();
            newCustomer.fName = "orzalena";
            newCustomer.lName = "elelqa";
            newCustomer.custNum = 128;

            return View("showCustomerDetails",newCustomer);// return the page. 
        }
 
        public IActionResult deleteCustomer()
        {
            //...

            return View();// return the page. 
        }
        public IActionResult customerSignin()
        {
            //...

            return View();// return the page. 
        }
        public IActionResult customersignup()
        {
            //...

            return View();// return the page. 
        }
        public IActionResult sCustomerSignout()
        {
            //...

            return View();// return the page. 
        }
        public IActionResult regestration()
        {
            /*[Route("")]
            [Route("Customer/CcustomerSignin")]
            [Route("Seller/sellerLogin")]*/
            return View();
        }
    }
}
