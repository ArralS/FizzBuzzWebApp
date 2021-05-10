using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Legion1.Models;
using Microsoft.AspNetCore.Http;
using Legion1.Data;
using Microsoft.Extensions.Logging;

namespace Legion1.Pages
{
    public class Index2Model : PageModel
    {
        
        private ILogger<IndexModel> _logger;
        private NumberContext _context;
        [BindProperty]
        public int id { get; set; }
        

        public Index2Model(ILogger<IndexModel> logger, NumberContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Recent> Results { get; set; }
        public void OnGet()
        {
            Results = _context.Recent.OrderByDescending(d => d.Data).Take(10).ToList();
           
        }
        public IActionResult OnPost()
        {
            _context.Remove(new Recent() {ID=id});
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}

