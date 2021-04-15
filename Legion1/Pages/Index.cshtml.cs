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
        
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public String GetResult(int Number)
        {

            String result = "";
            if (Number % 3 == 0) result += "Fizz";
            if (Number % 5 == 0) result += "Buzz";
            if (result == String.Empty) {
                result = "Liczba: ";
                result += Number.ToString();
                result += " nie spełnia kryteriów Fizz / Buzz";


            }
            return result;
        }
        public IActionResult OnPost()
        {

          
            if (ModelState.IsValid)
            {
                Name = GetResult(Address.Number);
                HttpContext.Session.SetString("SessionAddress",
                JsonConvert.SerializeObject(new Recent() { Number = Address.Number, Result = Name, Data = DateTime.Now }));
                return Page();
            }
            return Page();

          

        }

    }
}
