/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.PharmacyManagementLibrary;

public interface IDoctorRepository : IMedicalBaseRepository<Doctor>
{
    Doctor Add(string name, string qualification, string specialization, string hospital, string contact);
}


public class DoctorRepository : IDoctorRepository
{
    private readonly List<Doctor> _doctors;

    public DoctorRepository()
    {
        _doctors = [];
    }

    public Doctor Add(string name, string qualification, string specialization, string hospital, string contact)
    {
        var doctor = new Doctor
        {
            Name = name,
            Qualification = qualification,
            Specialization = specialization,
            Hospital = hospital,
            Contact = contact
        };

        _doctors.Add(doctor);
        return doctor;
    }

    public List<Doctor> GetAll()
    {
        return _doctors;
    }

    public Doctor? GetByName(string name)
    {
        return _doctors.Find(doctor => doctor.Name == name);
    }

    public bool Update(Doctor doctor)
    {
        var existingDoctor = _doctors.Find(doctorAtIndex => doctorAtIndex.Name == doctor.Name);

        if (existingDoctor == null) return false;

        existingDoctor.Qualification = doctor.Qualification;
        existingDoctor.Specialization = doctor.Specialization;
        existingDoctor.Hospital = doctor.Hospital;
        existingDoctor.Contact = doctor.Contact;
        return true;
    }

    public bool Delete(Doctor doctor)
    {
        return _doctors.Remove(doctor);
    }

    public Doctor this[int index]
    {
        get
        {
            if (index >= 0 && index < _doctors.Count)
            {
                return _doctors[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}
