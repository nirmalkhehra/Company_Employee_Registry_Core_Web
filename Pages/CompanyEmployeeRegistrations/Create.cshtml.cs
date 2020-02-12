using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Company_Employee_Registry_Core_Web.BusinessLayer;
using Company_Employee_Registry_Core_Web.Models;

namespace Company_Employee_Registry_Core_Web.Pages.CompnayEmployeeRegistrations
{
    public class CreateModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public CreateModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Name");
        ViewData["EmployeeId"] = new SelectList(_context.Set<Employee>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public CompanyEmployeeRegistration CompanyEmployeeRegistration { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CompanyEmployeeRegistration.Add(CompanyEmployeeRegistration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
