using System.ComponentModel.DataAnnotations;

namespace TestDeliveryApp.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        [Required]
        public string SenderCity { get; set; }
        [Required]
        public string SenderAdress { get; set; }
        [Required]
        public string RecipientCity { get; set; }
        [Required]
        public string RecipientAdress { get; set; }
        [Required]
        public int CargoWeight { get; set; }
        [Required]
        public DateTime CargoPickUpDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}
