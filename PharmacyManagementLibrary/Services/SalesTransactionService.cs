/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public interface ISalesTransactionService : IManagementBaseService<SalesTransaction>
{
    SalesTransaction Add(Prescription prescription, Member memberType);
}

public class SalesTransactionService : ISalesTransactionService
{
    private readonly ISalesTransactionRepository _salesTransactionRepository;

    public SalesTransactionService(ISalesTransactionRepository salesTransactionRepository)
    {
        _salesTransactionRepository = salesTransactionRepository;
    }

    public SalesTransaction Add(Prescription prescription, Member memberType)
    {
        return _salesTransactionRepository.Add(prescription, memberType);
    }

    public List<SalesTransaction> GetAll()
    {
        return _salesTransactionRepository.GetAll();
    }

    public SalesTransaction? GetById(int id)
    {
        return _salesTransactionRepository.GetById(id);
    }

    public bool Update(SalesTransaction salesTransaction)
    {
        return _salesTransactionRepository.Update(salesTransaction);
    }

    public bool Delete(SalesTransaction salesTransaction)
    {
        return _salesTransactionRepository.Delete(salesTransaction);
    }
}
