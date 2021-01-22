using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using McCarSales.Models;
using System;
using System.Linq;

namespace McCarSales.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new ApplicationDbContext(
               serviceProvider.GetRequiredService<
               DbContextOptions<ApplicationDbContext>>()))
            {
                if (!context.Lot.Any())

                {
                    context.Lot.AddRange(
                       new Lot
                       {
                           Name = "Avon Imports",
                           StreetAddress = "411 Woodland Lane",
                           ZipCode = "07717",
                           PhoneNumber = "908-785-1515",
                           ManagerName = "Rosemary Coakley"
                       },
                       new Lot
                       {
                           Name = "Belmar Used Cars",
                           StreetAddress = "5th Avenue",
                           ZipCode = "07717",
                           PhoneNumber = "732-885-1515",
                           ManagerName = "Leigh Walker"
                       }
                       );
                    context.SaveChanges();
                }

                if (context.Cars.Count()>4)
                {
                    return;
                }

                var lotId = context.Lot.FirstOrDefault(l => l.Name == "Avon Imports").Id;

                context.Cars.AddRange(
                    new Car
                    {
                        Make = "Toyota",
                        Model = "4Runner",
                        ModelYear = 2000,
                        Mileage = 2000,
                        Price = 33500,
                        Color = "Brown",
                        Drive = "4WD",
                        LotId = lotId

                    },
                    new Car
                    {
                        Make = "Honda",
                        Model = "Civic",
                        ModelYear = 2021,
                        Mileage = 4000,
                        Price = 25000,
                        Color = "White",
                        Drive = "2WD",
                        LotId = lotId

                    },
                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Tahoe",
                        ModelYear = 2014,
                        Mileage = 75000,
                        Price = 17000,
                        Color = "Red",
                        Drive = "4WD",
                        LotId = lotId

                    },
                    new Car
                    {
                        Make = "Ford",
                        Model = "Mustang",
                        ModelYear = 1970,
                        Mileage = 58000,
                        Price = 21000,
                        Color = "Blue",
                        Drive = "2WD",
                        LotId = lotId
                    },
                    new Car
                    {
                        Make = "Nissan",
                        Model = "Sentra",
                        ModelYear = 2018,
                        Mileage = 40000,
                        Price = 15000,
                        Color = "Black",
                        Drive = "2WD",
                        LotId = lotId
                    }
                    );
                context.SaveChanges();
            }
         }
    }
}
