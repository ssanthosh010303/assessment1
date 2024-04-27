/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary.Models;

public enum Brand
{
    Pfizer,
    Novartis,
    Merck,
    JohnsonJhonson,
    GlaxoSmithKline,
    Roche,
    Sanofi,
    AstraZeneca,
    Bayer,
    EliLilly
}

public enum DosageType
{
    Tablet,
    Capsule,
    Liquid,
    Injection
}

public class Drug
{
    private string _name = "";
    private Brand _brand;
    private int _quantityInStock;
    private DateTime _expiryDate;
    private decimal _price;

    public DrugDosageDetails? DosageDetails { get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty or null.");
            }
            _name = value;
        }
    }

    public Brand Brand
    {
        get { return _brand; }
        set
        {
            if (!Enum.IsDefined(typeof(Brand), value))
            {
                throw new ArgumentException("Invalid brand provided.");
            }
            _brand = value;
        }
    }

    public int QuantityInStock
    {
        get { return _quantityInStock; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Quantity in stock cannot be negative.");
            }
            _quantityInStock = value;
        }
    }

    public DateTime ExpiryDate
    {
        get { return _expiryDate; }
        set
        {
            if (value < DateTime.Today)
            {
                throw new ArgumentException("Expiry date cannot be in the past.");
            }
            _expiryDate = value;
        }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            _price = value;
        }
    }

    public override string ToString()
    {
        string data = "";

        data += "\n----------------------------------------\n";
        data += $"Drug\n";
        data += "----------------------------------------\n";
        data += $"Name:        {Name}\n";
        data += $"Brand:       {Brand}\n";
        data += $"In stock:    {QuantityInStock}\n";
        data += $"Expiry date: {ExpiryDate}\n";
        data += $"Price:       {Price:C}\n";
        data += $"Dosage:      {DosageDetails}\n";

        data += "----------------------------------------\n";
        return data;
    }
}

public class DrugDosageDetails
{
    private int _strengthMg;
    private TimeOnly _timeForConsumption;
    private DosageType _dosageType;

    public int StrengthMg
    {
        get { return _strengthMg; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Strength must be greater than zero.");
            }
            _strengthMg = value;
        }
    }

    public TimeOnly TimeForConsumption
    {
        get { return _timeForConsumption; }
        set { _timeForConsumption = value; }
    }

    public DosageType DosageForm
    {
        get { return _dosageType; }
        set
        {
            if (!Enum.IsDefined(typeof(DosageType), value))
            {
                throw new ArgumentException("Invalid dosage type provided.");
            }
            _dosageType = value;
        }
    }

    public override string ToString()
    {
        return $"{DosageForm} {StrengthMg} mg at {TimeForConsumption}\n";
    }
}
