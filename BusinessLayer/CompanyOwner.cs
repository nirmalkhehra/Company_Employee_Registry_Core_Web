using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Employee_Registry_Core_Web.BusinessLayer
{
    //Company owner information
    public class CompanyOwner
    {
        //Owner id 
        public int Id { get; set; }

        //Owner name 
        public string Name { get; set; }

        //Emmail of the owner
        public string ContactEmail { get; set; }
    }
}
