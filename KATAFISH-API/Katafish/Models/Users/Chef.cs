using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Chef")]
    public class Chef : User
    {
        public string specialty { get; set; } = string.Empty;
        public string bio { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public string profilePicture { get; set; } = string.Empty;
    }
}