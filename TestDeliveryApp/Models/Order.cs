﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDeliveryApp.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Sender City")]
        public string SenderCity { get; set; }
        [Required]
        [Display(Name = "Sender Adress")]
        public string SenderAdress { get; set; }
        [Required]
        [Display(Name = "Recipient City")]
        public string RecipientCity { get; set; }
        [Required]
        [Display(Name = "Recipient Adress")]
        public string RecipientAdress { get; set; }
        [Required]
        [Display(Name = "Cargo Weight")]
        public int CargoWeight { get; set; }
        [Required]
        [Display(Name = "Cargo Pick Up Date")]
        public DateTime CargoPickUpDate { get; set; }
    }
}