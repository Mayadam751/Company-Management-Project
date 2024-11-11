using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Department? Department { get; set; }
        public Company? Company { get; set; }
        
        public int? EmployeeDepartmentId { get; set; }

    }
}
