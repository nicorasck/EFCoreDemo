using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models
{
    public class Person                             // this class is one table
    {
        public int Id  {get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [ForeignKey("Address")]                     // connecting to our separate class 'Address'
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
} 