using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Address_book.Models
{
    public class Person
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(10)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] ImageData { get; set; }

        [DisplayName("Address 1")]
        public int Address1 { get; set; }

        [DisplayName("Address 2")]
        public int Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DisplayName("Zip Code")]
        public int ZipCode { get; set; }

        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Added")]
        public DateTimeOffset DateAdded {get;set;}

    }
}
