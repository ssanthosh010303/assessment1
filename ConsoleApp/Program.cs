/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 *
 * Assessment-1: Pharmacy Management System
 */
using Assessment1.ConsoleApp.UserInterface;
using Assessment1.PharmacyManagementLibrary.Repositories;
using Assessment1.PharmacyManagementLibrary.Services;

namespace Assessment1.ConsoleApp;

class Program
{
    public static void Main()
    {
        IDoctorService doctorService = new DoctorService(new DoctorRepository());
        IPatientService patientService = new PatientService(new PatientRepository());
        IDrugService drugService = new DrugService(new DrugRepository());
        IPrescriptionService prescriptionService = new PrescriptionService(new PrescriptionRepository());
        ISalesTransactionService salesTransactionService = new SalesTransactionService(new SalesTransactionRepository());

        BaseUserInterface doctorInterface = new DoctorUserInterface(doctorService);
        BaseUserInterface patientInterface = new PatientUserInterface(patientService, doctorService);
        BaseUserInterface drugInterface = new DrugUserInterface(drugService);
        BaseUserInterface prescriptionInterface = new PrescriptionUserInterface(prescriptionService);
        BaseUserInterface salesTransactionInterface = new SalesTransactionUserInterface(salesTransactionService);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Pharmacy Management System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Manage Doctors");
            Console.WriteLine("2. Manage Patients");
            Console.WriteLine("3. Manage Drugs");
            Console.WriteLine("4. Manage Prescriptions");
            Console.WriteLine("5. Handle Sales Transactions");
            Console.WriteLine("0. Exit");
            Console.WriteLine("----------------------------------------");
            Console.Write("Enter your choice: ");

            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        doctorInterface.Manage();
                        break;
                    case "2":
                        patientInterface.Manage();
                        break;
                    case "3":
                        drugInterface.Manage();
                        break;
                    case "4":
                        prescriptionInterface.Manage();
                        break;
                    case "5":
                        salesTransactionInterface.Manage();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid option, please try again.");
                        break;
                }
                Console.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
    }
}
