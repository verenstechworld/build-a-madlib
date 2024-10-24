namespace VTWMidlab
{
    class Program
    {
         static void Main(string[] args)
         {
            string color, pluralNoun, superstar;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a Plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter the name of your favorite superstar: ");
            superstar = Console.ReadLine(); 
             
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + superstar);

            Console.ReadLine();
         }
    }
}