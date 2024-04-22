/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public interface IDoctorService : IMedicalBaseService<Doctor>
{
    Doctor Add(string name, string qualification, string specialization, string hospital, string contact);
}

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;

    public DoctorService(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public Doctor Add(string name, string qualification, string specialization, string hospital, string contact)
    {
        return _doctorRepository.Add(name, qualification, specialization, hospital, contact);
    }

    public List<Doctor> GetAll()
    {
        return _doctorRepository.GetAll();
    }

    public Doctor? GetByName(string name)
    {
        return _doctorRepository.GetByName(name);
    }

    public bool Update(Doctor doctor)
    {
        return _doctorRepository.Update(doctor);
    }

    public bool Delete(Doctor doctor)
    {
        return _doctorRepository.Delete(doctor);
    }
}
