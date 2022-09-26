using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string StreatName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int EmployeeId { get; set; }
    }
}
