using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Company_Employee_Registry_Core_Web.BusinessLayer;
using Company_Employee_Registry_Core_Web.Models;

namespace Company_Employee_Registry_Core_Web.Pages.CompnayEmployeeRegistrations
{
    public class DeleteModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public DeleteModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CompanyEmployeeRegistration CompanyEmployeeRegistration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompanyEmployeeRegistration = await _context.CompanyEmployeeRegistration
                .Include(c => c.Company)
                .Include(c => c.Employee).FirstOrDefaultAsync(m => m.Id == id);

            if (CompanyEmployeeRegistration == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompanyEmployeeRegistration = await _context.CompanyEmployeeRegistration.FindAsync(id);

            if (CompanyEmployeeRegistration != null)
            {
                _context.CompanyEmployeeRegistration.Remove(CompanyEmployeeRegistration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
