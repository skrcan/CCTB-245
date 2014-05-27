using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Product
    {
        // Auto-implemented properties (data)
        public int Id { get; set; } // int will have a deafult of 0
        public string Name { get; set; } // string has a dafault of null

        // Constructors (define the different "ways" to make my objects)
        // Parameterless constructor
        public Product()
        {
            // empty body - let the properties ' values be their defaults
        }

        // Greedy Constructor
        public Product(int id, string name)
        {
            // simply store the information into my properties/fielfd
            Id = id;
            Name = name;
        }
        // Virtual Method - Use "virtual" when you intend subclasses to "override" the behaviour
        public virtual void Purchase()
        {
            // Temp - just output to console
            Console.WriteLine("Product Purchase {0}", Name);
        }

    }
}
