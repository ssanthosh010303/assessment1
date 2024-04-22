/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public class Doctor
{
    private string _name = "";
    private string _qualification = "";
    private string _specialization = "";
    private string _hospital = "";
    private string _contact = "";

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

    public string Qualification
    {
        get { return _qualification; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Qualification cannot be empty or null.");
            }
            _qualification = value;
        }
    }

    public string Specialization
    {
        get { return _specialization; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Specialization cannot be empty or null.");
            }
            _specialization = value;
        }
    }

    public string Hospital
    {
        get { return _hospital; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Hospital cannot be empty or null.");
            }
            _hospital = value;
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
}
