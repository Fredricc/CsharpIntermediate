namespace CsharpIntermediate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Fresh");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}