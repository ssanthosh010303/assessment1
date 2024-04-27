/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Models;
using Assessment1.PharmacyManagementLibrary.Repositories;

namespace Assessment1.PharmacyManagementLibrary.Services;

public interface IPatientService : IMedicalBaseService<Patient>
{
    Patient Add(string name, string contact, Doctor referredDoctor);
}

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public Patient Add(string name, string contact, Doctor referredDoctor)
    {
        return _patientRepository.Add(name, contact, referredDoctor);
    }

    public List<Patient> GetAll()
    {
        return _patientRepository.GetAll();
    }

    public Patient? GetByName(string name)
    {
        return _patientRepository.GetByName(name);
    }

    public bool Update(Patient patient)
    {
        return _patientRepository.Update(patient);
    }

    public bool Delete(Patient patient)
    {
        return _patientRepository.Delete(patient);
    }
}
