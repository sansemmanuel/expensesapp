using System.ComponentModel.DataAnnotations;

namespace expensesapp.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }   
       //Cat ID
       public int CategoryId { get; set; }  
        
        public int Amount { get; set; } 
        public string? Notes { get; set; }   
        public DateTime Date {  get; set; } = DateTime.UtcNow;

    }
}
