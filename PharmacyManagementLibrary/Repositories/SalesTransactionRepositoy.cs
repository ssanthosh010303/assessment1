/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public interface ISalesTransactionRepository : IManagementBaseRepository<SalesTransaction>
{
    SalesTransaction Add(Prescription prescription, Member memberType);
}

public class SalesTransactionRepository : ISalesTransactionRepository
{
    private List<SalesTransaction> _salesTransactions;

    public SalesTransactionRepository()
    {
        _salesTransactions = [];
    }

    public SalesTransaction Add(Prescription prescription, Member memberType)
    {
        var salesTransaction = new SalesTransaction(prescription: prescription)
        {
            MemberType = memberType
        };

        _salesTransactions.Add(salesTransaction);
        return salesTransaction;
    }

    public List<SalesTransaction> GetAll()
    {
        return _salesTransactions;
    }

    public SalesTransaction? GetById(int id)
    {
        return _salesTransactions.Find(salesTransaction => salesTransaction.Id == id);
    }

    public bool Update(SalesTransaction salesTransaction)
    {
        var existingSalesTransaction = _salesTransactions.Find(salesTransactionAtIndex => salesTransactionAtIndex.Id == salesTransaction.Id);

        if (existingSalesTransaction == null) return false;
        return true;
    }

    public bool Delete(SalesTransaction transaction)
    {
        return _salesTransactions.Remove(transaction);
    }

    public SalesTransaction this[int index]
    {
        get
        {
            if (index >= 0 && index < _salesTransactions.Count)
            {
                return _salesTransactions[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}
