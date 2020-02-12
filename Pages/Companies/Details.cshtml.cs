using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Company_Employee_Registry_Core_Web.BusinessLayer;
using Company_Employee_Registry_Core_Web.Models;

namespace Company_Employee_Registry_Core_Web.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public DetailsModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.CompanyOwner).FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
