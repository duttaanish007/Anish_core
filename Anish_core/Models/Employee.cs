using System.ComponentModel.DataAnnotations;

namespace Anish_core.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string email { get; set; }
        
        public string phone { get; set; }
        public string city { get; set; }


    }
}
