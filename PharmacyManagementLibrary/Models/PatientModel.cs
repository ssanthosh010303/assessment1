/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary.Models;

public class Patient
{
    private string _name = "";
    private string _contact = "";
    private Doctor _referredDoctor = new();

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

    public string Contact
    {
        get { return _contact; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Contact cannot be empty or null.");
            }
            if (value.Length > 15)
            {
                throw new ArgumentException("Invalid phone number.");
            }
            _contact = value;
        }
    }

    public Doctor ReferredDoctor
    {
        get { return _referredDoctor; }
        set { _referredDoctor = value ?? throw new ArgumentNullException(nameof(ReferredDoctor)); }
    }

    public override string ToString()
    {
        string data = "";

        data += "\n----------------------------------------\n";
        data += $"Patient\n";
        data += "----------------------------------------\n";
        data += $"Name:        {Name}\n";
        data += $"Contact:     {Contact}\n";
        data += $"Referred by: {ReferredDoctor.Name}\n";
        data += "----------------------------------------\n";
        return data;
    }
}
