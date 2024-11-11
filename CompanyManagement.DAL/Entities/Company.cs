using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Entities
{
    public class Company
    {

        public int CompanyId { get; set; }

        public string Name { get; set; }
        public string Registeration_No { get; set; }

        // Navigation Properties
        public ICollection<Department>? Departments { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<CompanyCustomers>? CompanyCustomers { get; set; }
    }
}
