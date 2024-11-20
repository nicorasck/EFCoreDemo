using EFCoreDemo.Models;
using System;

namespace EFCoreDemo;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("What would you like to do?");
        System.Console.WriteLine("1. - Add data.");
        System.Console.WriteLine("2. - Read data.");

        var _input = Console.ReadLine();

        if (_input == "1")
        {
            AddData.Run();
        }
    }


//     static void Main(string[] args)
//     {
//         Console.ForegroundColor = ConsoleColor.DarkBlue;
//         Console.WriteLine("Lesson 1 - Entity FrameWork - week 47\n");
//         Console.ForegroundColor = ConsoleColor.White;

//         using (var context = new AppDbContext())
//         {
//             // Create new address
//             var _address = new Address
//             {
//                 Street = "Main Street 48",
//                 City = "Katmandu"
//             };

//             // Add address in DataBase
//             context.Addresses.Add(_address);    // the table name is Address

//             // Create a new person and link it to the address
//             var _person = new Person
//             {
//                 Name = "Liza Tamang",
//                 Email = "Liza.Mini@gmail.com",
//                 Address = _address
//             };

//             // Add person in DataBase
//             context.People.Add(_person);    // the table name is People

//             // Save changes
//             context.SaveChanges();
//             System.Console.WriteLine("Data has been saved in the DataBase.");
//         }


//     }
}
