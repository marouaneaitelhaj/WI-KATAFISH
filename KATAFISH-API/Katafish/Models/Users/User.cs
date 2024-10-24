using System.ComponentModel.DataAnnotations;

namespace Katafish.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        protected string username { get; set; } = string.Empty;
        protected string firstName { get; set; } = string.Empty;
        protected string lastName { get; set; } = string.Empty;
        protected string email { get; set; } = string.Empty;
        protected string password { get; set; } = string.Empty;
        protected string phoneNumber { get; set; } = string.Empty;
    }
}