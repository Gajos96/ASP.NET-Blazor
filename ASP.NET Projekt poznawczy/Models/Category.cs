using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ASP.NET_Projekt_poznawczy.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Kolejność Wyświetlania")]
        [Range(1, 100, ErrorMessage = "Wartości z przedziału 1 do 100")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
