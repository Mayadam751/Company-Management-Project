using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Entities
{
    public class CompanyCustomers
    {
        public Company Companies { get; set; }
        public int CompanyId { get; set; }

        public Customer Customers { get; set; }
        public int CustomerId { get; set; }
    }
}
