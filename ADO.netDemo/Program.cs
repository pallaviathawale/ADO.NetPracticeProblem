namespace ADO.netDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer.CreateDatabase();
            //Customer.CreateDatabase();
           Customer.CreateTable();
            //Customer.insert();
        }
    }
}