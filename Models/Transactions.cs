using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expensesapp.Models
{
    public class Transactions
    {
        
        [Key]
        public int TransactionId { get; set; }   
       //Cat ID
       public int CategoryId { get; set; }  
        public Category Category { get; set; }
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(75)")]
        public string? Notes { get; set; }   
        public DateTime Date {  get; set; } = DateTime.UtcNow;

    }
}
