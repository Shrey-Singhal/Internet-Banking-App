using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCBA.Models;

public class BillPay
{
    [Key]
    public int BillPayID { get; set; }

    [Required]
    public int AccountNumber { get; set; }
    public Account Account { get; set; }

    [Required]
    public int PayeeID { get; set; }
    public Payee Payee { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    [Required]
    public DateTime ScheduleTimeUtc { get; set; }

    // New attribute (to check for "Failure", and flag it as such, if bill cant be paid)

    [Required]
    public char Period { get; set; }
}
