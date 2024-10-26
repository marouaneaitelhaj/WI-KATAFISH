using System.ComponentModel.DataAnnotations;

namespace Katafish.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
    }
}