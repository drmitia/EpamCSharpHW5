namespace epamHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first task
            Console.WriteLine("Введiть два числа");
            int first_number = Convert.ToInt32(Console.ReadLine());
            int seconnd_number = Convert.ToInt32(Console.ReadLine());   
            
            Console.WriteLine("Середнє арифметичне " + CalculateAverageNumber(first_number, seconnd_number));
        }
        static double CalculateAverageNumber(double x, double y)
        {
            return (x + y) / 2;
        }
    }
}