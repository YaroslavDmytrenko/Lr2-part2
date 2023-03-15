using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    class Product
    {
        public string Name { get; set; }
        public string ExportingCoutry { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Exporting Country: {ExportingCoutry}, Category: {Category}, Price: {Price}.";
        }

        public string Group()
        {
            return $"Name: {Name} - Price: {Price}.";
        }

        public static Product ParseProduct(string line)
        {
            string[] parts = line.Split(',');
            return new Product
            {
                Name = parts[0],
                ExportingCoutry = parts[1],
                Category = parts[2],
                //Price = int.Parse(parts[3])
            }; 
        }
    }
}
