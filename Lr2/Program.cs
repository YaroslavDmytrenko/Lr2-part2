using System;
using System.Text;

namespace Lr2
{
    class Program
    {
        delegate int StrLength(string s);
        static void Main(string[] args)
        {
            var productsFilter = File.ReadAllLines("file.txt")
                .Skip(1)    
                .Select(line =>
                {
                    var parts = line.Split(',');
                    return new Product
                    {
                        Name = parts[0],
                        ExportingCoutry = parts[1],
                        Category = parts[2],
                        Price = parts[3]
                    };
                })
                .Where(product => product.ExportingCoutry == "USA" || product.ExportingCoutry == "Italy") //filter
                //.OrderByDescending(product => int.Parse(product.Price))//sort
                .ToList();
            Console.WriteLine("Filter:");
            foreach (var product in productsFilter)
            {
                Console.WriteLine(product);
            }


            var productsSort = File.ReadAllLines("file.txt")
                .Skip(1)
                .Select(line =>
                {
                    var parts = line.Split(',');
                    return new Product
                    {
                        Name = parts[0],
                        ExportingCoutry = parts[1],
                        Category = parts[2],
                        Price = parts[3]
                    };
                })
                .OrderByDescending(product => int.Parse(product.Price))//sort
                .ToList()
                .Take(5);

            Console.WriteLine("\nSort:");
            foreach (var product in productsSort)
            {
                Console.WriteLine(product);
            }

            var productsGroup = File.ReadAllLines("file.txt")
                .Skip(1)
                .Select(line =>
                {
                    var parts = line.Split(',');
                    return new Product
                    {
                        Name = parts[0],
                        ExportingCoutry = parts[1],
                        Category = parts[2],
                        Price = parts[3]
                    };
                })
                .ToList()
                .Take(5);
            Console.WriteLine("\nGroup:");//+-Group
            foreach (var product in productsSort)
            {
                Console.WriteLine(product.Group());
            }


            string[] productsLines = { "Orange", "Milk 2%", "Cheddar", "Spaghetti", "Chicken" };
            StrLength strLength = s => s.Length;

            Console.WriteLine("\nDelegat");

            foreach (var line in productsLines)
            {
                int length = strLength(line);
                Console.WriteLine($"{line}: {length}");
            }



        }
    }
}

