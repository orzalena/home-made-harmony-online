

using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using home_made_harmony_online.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using home_made_harmony_online.Models;

namespace home_made_harmony_online.Models
{
    public class SellerModel
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

    }
}
