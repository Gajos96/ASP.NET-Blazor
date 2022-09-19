using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace ASP.NET_Projekt_poznawczy.Models
{
    public partial class User
    {
        [Key]
        public int UserID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailID { get; set; }
        [Required]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        [Required]
        public System.Guid ActivationCode { get; set; }
    }



}
