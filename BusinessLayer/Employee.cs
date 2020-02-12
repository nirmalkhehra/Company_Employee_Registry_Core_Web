using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Employee_Registry_Core_Web.BusinessLayer
{
    //Employee assignd to a company
    public class Employee
    {
        //Employee id 
        public int Id { get; set; }

        //Employee name 
        public string Name { get; set; }

        //Employee email.
        public string Email { get; set; }

    }
}
