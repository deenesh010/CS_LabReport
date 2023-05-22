namespace Lab_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter two numbers: ");
            Num1 = Convert.ToInt16(Console.ReadLine());
            Num2 = Convert.ToInt16(Console.ReadLine());
            int sum=Num1 + Num2;
            Console.WriteLine("Sum of two numbers is : " + sum);
            Console.ReadLine();
        }
    }
}