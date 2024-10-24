using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Waiter")]
    public class Waiter : User
    {
        protected string bio { get; set; } = string.Empty;
        protected string location { get; set; } = string.Empty;
        protected string profilePicture { get; set; } = string.Empty;
    }
}