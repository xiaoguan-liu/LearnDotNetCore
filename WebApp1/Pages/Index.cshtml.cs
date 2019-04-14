using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using WebApp1.Models;

namespace WebApp1.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IOptions<MyOptions> optionsAccessor)
        {
            var a = optionsAccessor.Value;
        }

        public void OnGet()
        {

        }
    }
}
