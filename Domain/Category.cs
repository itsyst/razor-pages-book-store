using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Order { get; set; }  

    }
}
