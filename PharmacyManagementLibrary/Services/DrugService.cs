/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public interface IDrugService : IMedicalBaseService<Drug>
{
    Drug Add(string name, Brand brand, int quantityInStock, DateTime expiryDate, decimal price, List<DrugDosageDetails> dosageDetails);
}

public class DrugService : IDrugService
{
    private readonly IDrugRepository _drugRepository;

    public DrugService(IDrugRepository drugRepository)
    {
        _drugRepository = drugRepository;
    }

    public Drug Add(string name, Brand brand, int quantityInStock, DateTime expiryDate, decimal price, List<DrugDosageDetails> dosageDetails)
    {
        return _drugRepository.Add(name, brand, quantityInStock, expiryDate, price, dosageDetails);
    }

    public List<Drug> GetAll()
    {
        return _drugRepository.GetAll();
    }

    public Drug? GetByName(string name)
    {
        return _drugRepository.GetByName(name);
    }

    public bool Update(Drug drug)
    {
        return _drugRepository.Update(drug);
    }

    public bool Delete(Drug drug)
    {
        return _drugRepository.Delete(drug);
    }
}
