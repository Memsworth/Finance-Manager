using FinanceMan.Domain.Enums;
namespace FinanceMan.Domain;

public class Transaction
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal TransactionAmount { get; set; }
    public virtual User User { get; set; }
    public TransactionType TransactionType { get; set; }
}