using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Security.Cryptography;

public class AddData
{
    public static void Run()
    {
        using (var context = new AppDbContext())
        {
            // Create new address
            var _address = new Address
            {
                Street = "Main Street 48",
                City = "Katmandu"
            };

            // Add address in DataBase
            context.Addresses.Add(_address);    // the table name is Address

            // Create a new person and link it to the address
            var _person = new Person
            {
                Name = "Liza Tamang",
                Email = "Liza.Mini@gmail.com",
                Address = _address
            };

            // Add person in DataBase
            context.People.Add(_person);    // the table name is People

            // Save changes
            context.SaveChanges();
            System.Console.WriteLine("Data has been saved in the DataBase.");
        }

    }
}