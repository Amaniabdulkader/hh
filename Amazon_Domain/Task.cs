using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Domain
{
    public class Task
    {
        public int TaskId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public List<Category> categories { get; set; } = new List<Category>();

    }
}
