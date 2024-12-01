using System.ComponentModel.DataAnnotations;

namespace Anish_core.Models
{
    public class Catagory
    {
        [Key]
        public int Catagory_Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
