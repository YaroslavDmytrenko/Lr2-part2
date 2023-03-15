namespace Delgts
{
    public class Program
    {
        delegate int StringLength(string str);

        static void Main(string[] args)
        {
            string[] words = { "Orange", "Milk 2%", "Cheddar", "Spaghetti", "Chicken" };

            StringLength stringLength = s => s.Length;

            foreach (string word in words)
            {
                int length = stringLength(word);
                Console.WriteLine($"{word}: {length}");
            }
        }
    }
}