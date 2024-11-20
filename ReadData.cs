using Microsoft.EntityFrameworkCore;
using System;
using EFCoreDemo.Models;
using System.Linq;

public class ReadData
{
    public static void Run()
    {
        using (var context = new AppDbContext())
        {
            var _persons = context.People
            .Include(p => p.Address)   // include relation to address
            .ToList();
            // Check
            if (_persons.Any())
            {
                foreach (var person in _persons)
                {
                    System.Console.WriteLine($"Name: {person.Name}, Email: {person.Email}, Address: {person.Address.Street}, City: {person.Address.City}");
                }
            }
            else
            {
                System.Console.WriteLine("No match in the DataBase!");
            }
        }
    }
}