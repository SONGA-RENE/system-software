using System.ComponentModel.DataAnnotations;

namespace MSRpharmacy.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Name is required with less than 200 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Category is required with less than 200 characters")]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string ImageName { get; set; }
    }
}