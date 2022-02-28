using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models;

namespace ERP.Pages.ns_Products
{
    public class IndexModel : PageModel
    {
        private readonly ERP.Data.ERPContext _context;

        public IndexModel(ERP.Data.ERPContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
