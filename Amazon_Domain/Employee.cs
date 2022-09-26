using System.ComponentModel.DataAnnotations;

namespace Amazon_Domain
{
    public class Employee
    {
        public Employee()
        {
            Tasks = new List<Task>(); 
            Isdeleted = false;
        
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        public bool Isdeleted { get; set; }
        
        public List<Task> Tasks { get; set; }
        public Address Address { get; set; }

       
    }
}