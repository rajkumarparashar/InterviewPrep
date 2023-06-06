namespace InterviewPrep
{
    public class ReverseANumber
    {
        public static void PrintReverseNumber()
        {
            Console.WriteLine("Please enter a no to print REVERSE");
            var number = Convert.ToInt32(Console.ReadLine());
            int remainder =0, reversedNumber = 0;

            while (number > 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;    
                number = number / 10;
            }
            Console.WriteLine(reversedNumber);
        }
    }
}
