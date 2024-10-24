using System.ComponentModel.DataAnnotations.Schema;

namespace Katafish.Models
{
    [Table("Customer")]
    public class Customer : User
    {
        protected string address { get; set; } = string.Empty;
        protected string city { get; set; } = string.Empty;
        protected string state { get; set; } = string.Empty;
        protected string zipCode { get; set; } = string.Empty;
    }
}