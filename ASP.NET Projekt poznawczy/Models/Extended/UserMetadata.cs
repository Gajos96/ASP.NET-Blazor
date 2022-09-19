using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Projekt_poznawczy.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {
        [Display(Name = "Imie")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Imie jest wymagane")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email jest wymagany")]
        public string EmailID { get; set; }

        [Display(Name = "Data Urodzin")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy")]
        public DateTime DateOfBirth { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimalna ilość znaków: 6")]
        public string Password { get; set; }

        [Display(Name = "Potwierdzenie hasła")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Hasła nie są identyczne")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
