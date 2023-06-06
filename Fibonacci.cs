namespace InterviewPrep
{
    public class Fibonacci
    {
        public static void PrintFibonacci()
        {
            Console.WriteLine("Please enter a no to print Fibonacci");
            var count = Convert.ToInt32(Console.ReadLine());

            int number1 = 0, number2 = 1;

            Console.Write(number1 + " " + number2);
            GetFibonacci(count - 2, number1, number2);
        }

        static void GetFibonacci(int count, int number1, int number2)
        {
            if (count > 0)
            {
                int number3 = number1 + number2;
                Console.Write(" " + number3);
                number1 = number2;
                number2 = number3;
                GetFibonacci(count - 1, number1, number2);
            }
        }
    }
}
