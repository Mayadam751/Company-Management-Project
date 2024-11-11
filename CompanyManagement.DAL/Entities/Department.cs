using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }

        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

    }
}
