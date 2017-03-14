using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    public class AddressContact
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
    }
}
