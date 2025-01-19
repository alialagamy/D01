namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Tax = 0.06;
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("How many small Carpet do you want to clean? ");
            int nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many large Carpet do you want to clean? ");
            int numl = Convert.ToInt32(Console.ReadLine());

            double cost = (nums * 25) + (numl * 35);
            Console.WriteLine($"Cost: {cost}");
            
            double taxvalue = cost * Tax;
            Console.WriteLine($"Tax: {taxvalue}");

            double total = cost + taxvalue;
            Console.WriteLine($"Total estimate: {total} , This estimate is valid for 30 days");  
        }
    }
}
