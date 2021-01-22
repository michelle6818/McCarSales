using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace McCarSales.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public virtual Lot Lot { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string Make { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Model { get; set; }
        [Display(Name = "Model Year")]
        [Range(1950, 2023)]
        public int ModelYear { get; set; }

        public int Mileage { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Drive { get; set; }
    }
}
