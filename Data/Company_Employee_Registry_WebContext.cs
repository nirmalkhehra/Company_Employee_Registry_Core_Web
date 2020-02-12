using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Company_Employee_Registry_Core_Web.BusinessLayer;

namespace Company_Employee_Registry_Core_Web.Models
{
    //Provides the database connection by linking the business classes 
    public class Company_Employee_Registry_WebContext : DbContext
    {
        public Company_Employee_Registry_WebContext (DbContextOptions<Company_Employee_Registry_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Company_Employee_Registry_Core_Web.BusinessLayer.CompanyOwner> CompanyOwner { get; set; }

        public DbSet<Company_Employee_Registry_Core_Web.BusinessLayer.CompanyEmployeeRegistration> CompanyEmployeeRegistration { get; set; }

        public DbSet<Company_Employee_Registry_Core_Web.BusinessLayer.Company> Company { get; set; }

        public DbSet<Company_Employee_Registry_Core_Web.BusinessLayer.Employee> Employee { get; set; }
    }
}
