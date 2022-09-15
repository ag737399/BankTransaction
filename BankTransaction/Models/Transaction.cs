using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName="nvarchar(12)")]
        [DisplayName("Account Name")]
        [Required(ErrorMessage = "This field is required")]
        public string AccountName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName   { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Swift Code")]
        [Required(ErrorMessage ="This field is required")]
        public string SWIFTCode { get; set; }
        [DisplayName("Amount")]
        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        public DateTime Date{ get; set; }
    }
}
