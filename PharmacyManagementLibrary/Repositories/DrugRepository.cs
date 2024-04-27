/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Models;

namespace Assessment1.PharmacyManagementLibrary.Repositories;

public interface IDrugRepository : IMedicalBaseRepository<Drug>
{
    Drug Add(string name, Brand brand, int quantityInStock, DateTime expiryDate, decimal price, DrugDosageDetails dosageDetails);
}

public class DrugRepository : IDrugRepository
{
    private readonly List<Drug> _drugs;

    public DrugRepository()
    {
        _drugs = [];
    }

    public Drug Add(string name, Brand brand, int quantityInStock, DateTime expiryDate, decimal price, DrugDosageDetails dosageDetails)
    {
        var drug = new Drug
        {
            Name = name,
            Brand = brand,
            QuantityInStock = quantityInStock,
            ExpiryDate = expiryDate,
            Price = price,
            DosageDetails = dosageDetails
        };

        _drugs.Add(drug);
        return drug;
    }

    public List<Drug> GetAll()
    {
        return _drugs;
    }

    public Drug? GetByName(string name)
    {
        return _drugs.Find(drug => drug.Name == name);
    }

    public bool Update(Drug drug)
    {
        var existingDrug = GetByName(drug.Name);

        if (existingDrug == null) return false;

        existingDrug.Brand = drug.Brand;
        existingDrug.QuantityInStock = drug.QuantityInStock;
        existingDrug.ExpiryDate = drug.ExpiryDate;
        existingDrug.Price = drug.Price;
        existingDrug.DosageDetails = drug.DosageDetails;
        return true;
    }

    public bool Delete(Drug drug)
    {
        return _drugs.Remove(drug);
    }

    public Drug this[int index]
    {
        get
        {
            if (index >= 0 && index < _drugs.Count)
            {
                return _drugs[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}
