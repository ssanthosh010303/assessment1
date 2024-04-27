/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Services;

namespace Assessment1.ConsoleApp.UserInterface;

class DoctorUserInterface(IDoctorService doctorService) : BaseUserInterface
{
    private readonly IDoctorService _doctorService = doctorService;

    public override void Add()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void Get()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}
