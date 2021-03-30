using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NineStarKi.Models;

namespace NineStarKi.Pages
{
    public class IndexModel : PageModel
    {
        public IRepository Repository { get; set; }

        public void OnGet(IRepository repo)
        {
            Repository = repo;
        }
    }
}
