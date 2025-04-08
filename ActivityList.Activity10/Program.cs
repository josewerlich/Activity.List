namespace ActivityList.Activity10
{
    internal class Program
    {   
        //create a program to validate the "IMC" for adults. 
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Type weight in KG:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Type height in Meters:");
            float height = float.Parse(Console.ReadLine());

            #endregion

            #region processing 
            float result = weight / (height * height);
            #endregion

            #region output

            if (result < 18.5)
            {
                Console.WriteLine("You are below the weight!");
            }
            else if (result >= 18.5 && result <= 25)
                Console.WriteLine("You are in the normal range for the weight!");

            else if (result >= 25 && result <= 30)
                Console.WriteLine("You are in the normal range for the weight!");
            else
                Console.WriteLine("You are obese!");

                Console.ReadLine();
            #endregion
        }
    }
}
