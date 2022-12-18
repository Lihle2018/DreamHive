using System.ComponentModel.DataAnnotations;

namespace DreamHive.Models
{
    public class Subscription
    {
        public string? Id { get; set; }
        [Required(ErrorMessage = "Please enter you email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid")]
        public string? Email { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
