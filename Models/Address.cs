using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Address                        // this class is one table
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        // public int ZipCode { get; set; }
        public ICollection<Person> People { get; set; }

    }
}