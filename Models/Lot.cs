using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace McCarSales.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Street Address")]
        public string  StreetAddress { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Manager's Name")]
        public string ManagerName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
