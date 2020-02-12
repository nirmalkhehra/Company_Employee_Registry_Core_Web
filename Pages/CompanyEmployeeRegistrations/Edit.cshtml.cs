using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Company_Employee_Registry_Core_Web.BusinessLayer;
using Company_Employee_Registry_Core_Web.Models;

namespace Company_Employee_Registry_Core_Web.Pages.CompnayEmployeeRegistrations
{
    public class EditModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public EditModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
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
           ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Name");
           ViewData["EmployeeId"] = new SelectList(_context.Set<Employee>(), "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CompanyEmployeeRegistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyEmployeeRegistrationExists(CompanyEmployeeRegistration.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompanyEmployeeRegistrationExists(int id)
        {
            return _context.CompanyEmployeeRegistration.Any(e => e.Id == id);
        }
    }
}
