using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDeliveryApp.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Sender City")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,50}$")]
        public string SenderCity { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,50}$")]
        [Display(Name = "Sender Adress")]
        public string SenderAdress { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,50}$")]
        [Display(Name = "Recipient City")]
        public string RecipientCity { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,50}$")]
        [Display(Name = "Recipient Adress")]
        public string RecipientAdress { get; set; }
        [Required]
        [Display(Name = "Cargo Weight")]
        public int CargoWeight { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cargo Pick Up Date")]
        public DateTime CargoPickUpDate { get; set; }
    }
}