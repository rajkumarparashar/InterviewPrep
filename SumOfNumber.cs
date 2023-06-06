namespace InterviewPrep
{
    public class SumOfNumber
    {
        public static void PrintSumOfNumber()
        {
            Console.WriteLine("Please enter a no to print SUM");
            var number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
