using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Legion1.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace Legion1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz Address { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }

        }

        public IActionResult OnPost()
        {

            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }

            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionAddress",
                JsonConvert.SerializeObject(Address));
                return Page();
            }
            return Page();

          

        }

    }
}
