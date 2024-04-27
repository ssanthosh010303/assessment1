/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Models;

namespace Assessment1.PharmacyManagementLibrary.Repositories;

public interface IPrescriptionRepository : IManagementBaseRepository<Prescription>
{
    Prescription Add(Patient patient, Doctor doctor, List<Drug> prescribedDrugs);
}

public class PrescriptionRepository : IPrescriptionRepository
{
    private readonly List<Prescription> _prescriptions;

    public PrescriptionRepository()
    {
        _prescriptions = [];
    }

    public Prescription Add(Patient patient, Doctor doctor, List<Drug> prescribedDrugs)
    {
        var prescription = new Prescription
        {
            Id = _prescriptions.Count + 1,
            PatientEntity = patient,
            DoctorEntity = doctor,
            PrescribedDrugs = prescribedDrugs
        };

        _prescriptions.Add(prescription);
        return prescription;
    }

    public List<Prescription> GetAll()
    {
        return _prescriptions;
    }

    public Prescription? GetById(int id)
    {
        return _prescriptions.Find(prescription => prescription.Id == id);
    }

    public bool Update(Prescription prescription)
    {
        var existingPrescription = GetById(prescription.Id);

        if (existingPrescription == null) return false;

        existingPrescription.PatientEntity = prescription.PatientEntity;
        existingPrescription.DoctorEntity = prescription.DoctorEntity;
        return true;
    }

    public bool Delete(Prescription prescription)
    {
        return _prescriptions.Remove(prescription);
    }

    public Prescription this[int index]
    {
        get
        {
            if (index >= 0 && index < _prescriptions.Count)
            {
                return _prescriptions[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}
