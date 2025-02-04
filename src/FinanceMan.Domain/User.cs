namespace FinanceMan.Domain;

public class User
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdate { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
}
