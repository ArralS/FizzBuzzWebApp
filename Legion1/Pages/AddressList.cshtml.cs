using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Legion1.Models;
using Microsoft.AspNetCore.Http;

namespace Legion1.Pages
{
    public class AddressListModel : PageModel
    {
        public Recent Legion { get; set; }
        public void OnGet()
        {
            var sessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (sessionAddress != null) Legion = JsonConvert.DeserializeObject<Recent>(sessionAddress);
        }

    }
}

