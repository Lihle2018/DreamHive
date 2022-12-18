using System.ComponentModel.DataAnnotations;

namespace DreamHive.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please enter you email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage = "Email is not valid")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Please enter the subject")]
        public string? Subject { get; set; }
        [Required(ErrorMessage ="Please write you message")]
        [MinLength(10,ErrorMessage ="Minimum characters is 10")]
        [MaxLength(1000,ErrorMessage ="Your message must not exceed 1000 characters")]
        public string? Message { get; set; }
    }
}
