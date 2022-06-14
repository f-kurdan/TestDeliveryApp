using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeliveryApp.Models
{
    public class Order
    {
        public int ID { get; set; }
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
    }
}