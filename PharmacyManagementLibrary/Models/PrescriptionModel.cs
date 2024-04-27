/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary.Models;

public class Prescription
{
    private int _id;
    private Patient _patient = new();
    private Doctor _doctor = new();
    private List<Drug> _prescribedDrugs = [];

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

    public Patient PatientEntity
    {
        get { return _patient; }
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            _patient = value;
        }
    }

    public Doctor DoctorEntity
    {
        get { return _doctor; }
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            _doctor = value;
        }
    }

    public List<Drug> PrescribedDrugs
    {
        get { return _prescribedDrugs; }
        set
        {
            foreach (var prescribedDrug in value)
            {
                _prescribedDrugs.Add(prescribedDrug);
            }
        }
    }

    public override string ToString()
    {
        string data = "";

        data += "\n----------------------------------------\n";
        data += $"Prescription\n";
        data += "----------------------------------------\n";
        data += $"Patient: {PatientEntity.Name}\n";
        data += $"Doctor:  {DoctorEntity.Name}\n";
        data += "----------------------------------------\n";
        data += "Drugs:\n";

        foreach (var drug in PrescribedDrugs)
        {
            data += "    * " + drug.Name;
        }

        data += "----------------------------------------\n";
        return data;
    }
}
