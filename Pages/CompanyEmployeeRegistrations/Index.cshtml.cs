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
    public class IndexModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public IndexModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
        {
            _context = context;
        }

        public IList<CompanyEmployeeRegistration> CompanyEmployeeRegistration { get;set; }

        public async Task OnGetAsync()
        {
            CompanyEmployeeRegistration = await _context.CompanyEmployeeRegistration
                .Include(c => c.Company)
                .Include(c => c.Employee).ToListAsync();
        }
    }
}
