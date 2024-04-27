/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 */
namespace Assessment1.ConsoleApp.UserInterface;

abstract class BaseUserInterface
{
    private bool _clearScreenEveryCommand = false;

    public virtual void Manage()
    {

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Sub-menu");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Get");
            Console.WriteLine("2. Get All");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Update");
            Console.WriteLine("5. Delete");
            Console.WriteLine("0. Exit");
            Console.WriteLine("----------------------------------------");
            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Get();
                    break;
                case "2":
                    GetAll();
                    break;
                case "3":
                    Add();
                    break;
                case "4":
                    Update();
                    break;
                case "5":
                    Delete();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Error: Invalid option, please try again.");
                    break;
            }

            if (_clearScreenEveryCommand) Console.Clear();
        }
    }

    public abstract void Get();
    public abstract void GetAll();
    public abstract void Add();
    public abstract void Update();
    public abstract void Delete();
}
