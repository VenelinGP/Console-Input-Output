using System;

/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
 * age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter Company Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter Company Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter Company Web Addres: ");
        string companyWebAddress = Console.ReadLine();

        Console.Write("Enter Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter Manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        
        if (companyPhoneNumber == "")
        {
            companyPhoneNumber = "(no phone number)";
        }
        if (companyFaxNumber == "")
        {
            companyFaxNumber = ("(no fax number)");
        }
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax. {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebAddress);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

