using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroomingSalonRegistrationApp
{
    class Pet
    {
        public int PetId { get; set; }

        public String Name { get; set; }

        public String Breed { get; set; }

        //Made a float because most animals won't live past roughly 25-30 
        public float Age { get; set; }
    }
}
