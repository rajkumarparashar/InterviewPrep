namespace InterviewPrep
{
    public class RightShiftArray
    {
        public static void Shift()
        {
            Console.WriteLine("Enter input array");
            var inputstr = Console.ReadLine();

            int[] input = inputstr.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();

            int temp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0 ; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
