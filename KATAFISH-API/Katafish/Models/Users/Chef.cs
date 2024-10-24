using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Chef")]
    public class Chef : User
    {
        protected string specialty { get; set; } = string.Empty;
        protected string bio { get; set; } = string.Empty;
        protected string location { get; set; } = string.Empty;
        protected string profilePicture { get; set; } = string.Empty;
    }
}