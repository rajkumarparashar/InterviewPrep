namespace InterviewPrep
{
    public class LeapYear
    {
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter year to check");
            int year = Convert.ToInt32(Console.ReadLine()); 

            if((year %4 == 0 && year %100 !=0) || year %400 ==0 ) {

                Console.WriteLine("{0} is leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year", year);
            }
        }
    }
}
