using System.ComponentModel.DataAnnotations;

namespace CrudRESTApis.Models
{
    public class Asset
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50, ErrorMessage = "Name cannot be more than 50 Characters")]
        public string Name {get; set; }
        public double Price { get; set; }
    }
}