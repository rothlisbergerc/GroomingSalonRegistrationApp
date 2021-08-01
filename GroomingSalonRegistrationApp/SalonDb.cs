using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GroomingSalonRegistrationApp
{
    static class SalonDb
    {
        /// <summary>
        /// Creates a list of all the customers to be retrieved by the database.
        /// </summary>
        public static List<Customer> getAllCustomers()
        {
            PetSalonContext context = new PetSalonContext();

            List<Customer> allCustomers =
                (from c in context.Customers
                 orderby c.LastName, c.FirstName
                 select c).ToList();

            return allCustomers;
        }

        public static List<Pet> getAllPets()
        {
            PetSalonContext context = new PetSalonContext();

            List<Pet> allPets =
                (from p in context.Pets
                 orderby p.Name
                 select p).ToList();

            return allPets;
        }

        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        public static Customer Add(Customer c)
        {
            using(PetSalonContext context = new PetSalonContext())
            {
                context.Customers.Add(c);
                context.SaveChanges();
                return c;
            }
        }

        public static Customer UpdateCust(Customer c)
        {
            using(PetSalonContext context = new PetSalonContext())
            {
                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
                return c;
            }
        }

        public static Pet Add(Pet p)
        {
            using(PetSalonContext context = new PetSalonContext())
            {
                context.Pets.Add(p);
                context.SaveChanges();
                return p;
            }
        }
    }
}
