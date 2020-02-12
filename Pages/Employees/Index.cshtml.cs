using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Company_Employee_Registry_Core_Web.BusinessLayer;
using Company_Employee_Registry_Core_Web.Models;

namespace Company_Employee_Registry_Core_Web.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext _context;

        public IndexModel(Company_Employee_Registry_Core_Web.Models.Company_Employee_Registry_WebContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await (from employee in _context.Employee
                              select employee
                              ).ToListAsync();
        }
    }
}
