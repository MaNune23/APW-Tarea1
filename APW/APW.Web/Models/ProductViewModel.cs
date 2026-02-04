using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APW.Web.Models
{
    public class ProductViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
