/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
using Assessment1.PharmacyManagementLibrary.Services;

namespace Assessment1.ConsoleApp.UserInterface;

class SalesTransactionUserInterface(ISalesTransactionService salesTransactionService) : BaseUserInterface
{
    private readonly ISalesTransactionService _salesTransactionService = salesTransactionService;

    public override void Manage()
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

    public override void Add()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }
}
