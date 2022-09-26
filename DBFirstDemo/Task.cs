using System;
using System.Collections.Generic;

namespace DBFirstDemo
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
