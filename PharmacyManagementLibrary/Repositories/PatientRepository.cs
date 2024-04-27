/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Models;

namespace Assessment1.PharmacyManagementLibrary.Repositories;

public interface IPatientRepository : IMedicalBaseRepository<Patient>
{
    Patient Add(string name, string contact, Doctor referredDoctor);
}

public class PatientRepository : IPatientRepository
{
    private readonly List<Patient> _patients;

    public PatientRepository()
    {
        _patients = [];
    }

    public Patient Add(string name, string contact, Doctor referredDoctor)
    {
        var patient = new Patient
        {
            Name = name,
            Contact = contact,
            ReferredDoctor = referredDoctor
        };

        _patients.Add(patient);
        return patient;
    }

    public List<Patient> GetAll()
    {
        return _patients;
    }

    public Patient? GetByName(string name)
    {
        return _patients.Find(patient => patient.Name == name);
    }

    public bool Update(Patient patient)
    {
        var existingPatient = GetByName(patient.Name);

        if (existingPatient == null) return false;

        existingPatient.Contact = patient.Contact;
        existingPatient.ReferredDoctor = patient.ReferredDoctor;
        return true;
    }

    public bool Delete(Patient patient)
    {
        return _patients.Remove(patient);
    }

    public Patient this[int index]
    {
        get
        {
            if (index >= 0 && index < _patients.Count)
            {
                return _patients[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}
