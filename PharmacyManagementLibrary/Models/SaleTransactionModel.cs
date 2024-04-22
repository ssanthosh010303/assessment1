/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public enum Member
{
    Bronze,
    Silver,
    Gold,
    Diamond
}

public class SalesTransaction
{
    private int _id;
    private Prescription _prescription;
    private decimal _totalCost;
    private decimal _discount;
    private decimal _finalCost;
    private DateTime _transactionDate;
    private Member _memberType;

    public int Id
    {
        get { return _id; }
        set
        {
            if (value <= 0 || value > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(Id));
            }
            _id = value;
        }
    }

    public Prescription PrescriptionEntity
    {
        get { return _prescription; }
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            _prescription = value;
        }
    }

    public decimal TotalCost
    {
        get { return _totalCost; }
        private set
        {
            _totalCost = value;
            CalculateFinalPrice();
        }
    }

    public Member MemberType
    {
        get { return _memberType; }
        set
        {
            if (!Enum.IsDefined(typeof(Member), value))
            {
                throw new ArgumentException("Invalid brand provided.");
            }
            _memberType = value;
        }
    }

    public decimal Discount
    {
        get { return _discount; }
        private set { _discount = value; }
    }

    public decimal FinalCost
    {
        get { return _finalCost; }
        private set { _finalCost = value; }
    }

    public DateTime TransactionDate
    {
        get { return _transactionDate; }
    }

    public SalesTransaction(Prescription prescription)
    {
        _prescription = prescription;
        _transactionDate = DateTime.Now;

        foreach (var drug in prescription.PrescribedDrugs)
        {
            TotalCost += drug.Price;
        }
    }

    private decimal GetDiscountPercentage()
    {
        return ((int) MemberType) / 100;
    }

    private void CalculateFinalPrice()
    {
        Discount = _totalCost * (GetDiscountPercentage() / 100);
        FinalCost = _totalCost - _discount;
    }

    public override string ToString()
    {
        string data = "";

        data += $"\nSales Receipt - {TransactionDate}\n";
        data += "----------------------------------------\n";
        data += "Drugs:\n";

        foreach (var drug in PrescriptionEntity.PrescribedDrugs)
        {
            data += "    * " + drug.Name;
        }

        data += "----------------------------------------\n";
        data += $"Total cost: {TotalCost:C}\n";
        data += $"Discount:   {Discount:C}\n";
        data += $"Final cost: {FinalCost:C}\n";
        data += "----------------------------------------\n";
        return data;
    }
}
