namespace CsharpIntermediate
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("Conversion failed");
            }

            int number;
            var result = int.TryParse("44", out number);
            if(result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 4, 8));
            Console.WriteLine(calculator.Add(9, 7, 12, 4, 8));
            Console.WriteLine(calculator.Add(1, 8));

            var customer = new Customer(1, "Fresh");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

            static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(new Point(100, 200));
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception)
            {

                Console.WriteLine("Unexpected error occured.. ");
            }
        }

        }
    }