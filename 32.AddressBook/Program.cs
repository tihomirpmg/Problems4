using _32.AddressBook;
using System;
using System.Collections.Generic;

class AddressEntry
{
    AddressBook addbook;
    public AddressEntry()
    {
        addbook = new AddressBook();
    }
    static void Main(string[] args)
    {
        string select = "";
        AddressEntry entry = new AddressEntry();
        entry.displayMenu();
        while (!select.ToUpper().Equals("Q"))
        {
            Console.WriteLine("Select: ");
            select = Console.ReadLine();
            entry.performAction(select);
        }
    }
    //show menu to choose and option
    void displayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("=============");
        Console.WriteLine("A - Add new address");
        Console.WriteLine("R - Remove added address");
        Console.WriteLine("S - Show all addresess");
        Console.WriteLine("Q - Quit the app");
    }
    void performAction(string select)
    {
        //switch case for the options
        string name = "";
        string address = "";
        int gsm;
        switch (select.ToUpper())
        {
            //add address
            case "A":
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                address = Console.ReadLine();
                Console.WriteLine("Enter GSM: ");
                gsm = int.Parse(Console.ReadLine());
                if (addbook.add(name, address, gsm))
                {
                    Console.WriteLine("Address adding was successfully!");
                }
                else
                {
                    Console.WriteLine("An address is registered for {0}.", name);
                }
                break;
                //remove address
            case "R":
                Console.WriteLine("Enter name to remove: ");
                name = Console.ReadLine();
                if (addbook.remove(name))
                {
                    Console.WriteLine("Address was removed!");
                }
                else
                {
                    Console.WriteLine("Address for {0} is not found.", name);
                }
                break;
                //show addresess
            case "S":
                if (addbook.isEmpty())
                {
                    Console.WriteLine("First add entries.");
                }
                else
                {
                    Console.WriteLine("Addresses:");
                    addbook.list((a) => Console.WriteLine("{0} - {1} - {2}", a.name, a.address, a.gsm));
                    Console.WriteLine("----------------------------------------");
                }
                break;
        }
    }
}