namespace DataAccess;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
public static class Seeder
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {

            if (!context.Customers.Any())
            {
                var customer1 = new Customer { ForeName = "Russel" , SurName = "Charleston" , EmailAddress = "something@somewhere.com" , IsActive = true, Addresses = new List<Address>
                {
                    new Address{ AddressLine1 = "something street",AddressLine2 = "Bolton", Postcode = "BL1 27E", IsMainAddress = false},
                    new Address{ AddressLine1 = "something else street",AddressLine2 = "Bolton", Postcode = "BL1 22E", IsMainAddress = true},

                }};

                 var customer2 = new Customer { ForeName = "James" , SurName = "Jacbos" , EmailAddress = "something3@somewhere.com" , IsActive = true, Addresses = new List<Address>
                {
                    new Address{ AddressLine1 = "something street 2",AddressLine2 = "Bolton", Postcode = "BL1 29E", IsMainAddress = false},
                    new Address{ AddressLine1 = "something else street 2",AddressLine2 = "Bolton", Postcode = "BL1 21E", IsMainAddress = true},

                }};

                     var customer3 = new Customer { ForeName = "Jack" , SurName = "Jamerson" , EmailAddress = "something3@somewhere.com" , IsActive = true, Addresses = new List<Address>
                {
                    new Address{ AddressLine1 = "something street 2",AddressLine2 = "Bolton", Postcode = "BL1 26E", IsMainAddress = false},
                    new Address{ AddressLine1 = "something else street 2",AddressLine2 = "Bolton", Postcode = "BL2 22E", IsMainAddress = true},

                }};
                

                context.Customers.AddRange(customer1, customer2, customer3);
                context.SaveChanges();
            }
        }
    }
}
