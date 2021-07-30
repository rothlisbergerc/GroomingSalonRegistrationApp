using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroomingSalonRegistrationApp
{
    static class SalonDb
    {
        public static List<Customer> getAllCustomers()
        {
            PetSalonContext context = new PetSalonContext();

            List<Customer> allCustomers =
                (from c in context.Customers
                 orderby c.LastName, c.FirstName
                 select c).ToList();

            return allCustomers;
        }
    }
}
