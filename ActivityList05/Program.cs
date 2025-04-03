namespace ActivityList05
{
    internal class Program
    {
        //create a program to calculate a salary with base + comission. 
        //inform the base salary + total sales and the % of comission.
        static void Main(string[] args)
        {
            #region input
            Console.Write("Type base salary:$ ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Type the total sales:$");
            decimal sales = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Type the percentage of commission:$ ");
            decimal comission = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processing 
            decimal result = ((sales * comission)/100) + salary;
            #endregion

            #region output
            Console.WriteLine($"The salary + commission is: ${result}");
            Console.ReadLine();
            #endregion
        }
    }
}
