using Microsoft.Identity.Client;
using EFCoreDemo.Models;

using (var context = new AppDbContext())
{
    // Start transaction
    var transaction = context.Database.BeginTransaction();

    try
    {
        var _address = new Address
        {
            Street = "BlaBla Street",
            City = "Kau"
        };

        context.Addresses.Add(_address);

        // Saving changes
        context.SaveChanges();

        // Confirms the transaction
        transaction.Commit();

        var _person = new Person
        {
            Name = "Iona",
            Email = "Iona@gmail.com",
            Address = _address
        };

        context.People.Add(_person);
    }
    catch (Exception ex)
    {
        transaction.Rollback();
        System.Console.WriteLine("Ops! An error occurred: " + ex.Message);
    }
}