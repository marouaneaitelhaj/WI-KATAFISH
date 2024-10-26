using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Customer")]
    public class Customer : User
    {
        public string address { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string state { get; set; } = string.Empty;
        public string zipCode { get; set; } = string.Empty;
    }
}