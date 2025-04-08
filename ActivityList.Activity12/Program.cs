namespace ActivityList.Activity12
{
    internal class Program
    {
        //create a number to write odd numbers between 100 and 200
        static void Main(string[] args)
        {
            for (int counter = 101; counter <= 199; counter += 2)
            {
                int oddnumber = Convert.ToInt32(counter);
                Console.WriteLine(oddnumber);
            }
            Console.ReadLine();
        }
    }
}
