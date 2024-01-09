namespace CsharpIntermediate
{

    public class Program
    {
        static void Main(string[] args)
        {

             var point = new Point(10, 20);
            point.Move(new Point(40, 60));

            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(new Point(100, 200));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);



            var customer = new Customer(1, "Fresh");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}