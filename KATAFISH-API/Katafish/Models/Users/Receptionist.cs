using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Receptionist")]
    public class Receptionist : User
    {
        public string bio { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public string profilePicture { get; set; } = string.Empty;
    }
}