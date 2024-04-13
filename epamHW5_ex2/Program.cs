namespace epamHW5_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину масиву");
            int length = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[length];
            Console.WriteLine("Введiть елементи масиву");
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(ShowMaxNumberInArray(array));

            
            
         }
        static int ShowMaxNumberInArray(int[] array)
        {
            int max_number = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max_number)
                {
                    max_number = array[i];
                }
            }

            return max_number;
        }

    }
}
