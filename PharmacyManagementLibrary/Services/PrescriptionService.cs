/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Models;
using Assessment1.PharmacyManagementLibrary.Repositories;

namespace Assessment1.PharmacyManagementLibrary.Services;

public interface IPrescriptionService : IManagementBaseService<Prescription>
{
    Prescription Add(Patient patient, Doctor doctor, List<Drug> prescribedDrugs);
}

public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository _prescriptionRepository;

    public PrescriptionService(IPrescriptionRepository prescriptionRepository)
    {
        _prescriptionRepository = prescriptionRepository;
    }

    public Prescription Add(Patient patient, Doctor doctor, List<Drug> prescribedDrugs)
    {
        return _prescriptionRepository.Add(patient, doctor, prescribedDrugs);
    }

    public List<Prescription> GetAll()
    {
        return _prescriptionRepository.GetAll();
    }

    public Prescription? GetById(int id)
    {
        return _prescriptionRepository.GetById(id);
    }

    public bool Update(Prescription prescription)
    {
        return _prescriptionRepository.Update(prescription);
    }

    public bool Delete(Prescription prescription)
    {
        return _prescriptionRepository.Delete(prescription);
    }
}
