namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.Beep();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Declaring Variables and Constants");
            // declaring variables
            var number = 2;
            var totalPrice = 20.91f;
            var firstName = "Arjun";
            var isWorking = true;
            var num = 6;

            const float Pi = 3.14f;

            // printing variables
            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine();
            //constant log
            Console.WriteLine(Pi);
            Console.WriteLine();

            // formatting strings
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();


            // type conversion
            Console.WriteLine("Implicit and Explicit Type Conversion");

            // implicit conversion
            byte b = 1;
            int i = b;

            // explicit conversion
            string s = "10";
            int j = Convert.ToInt32(s);
            int k = int.Parse(s);

            //try catch block
            try
            {
                var number1 = "1234";
                byte b1 = Convert.ToByte(number1);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            // operators
            Console.WriteLine("Operators");

            var x = 10f;
            var y = 20f;

            //arithmetric operators
            Console.WriteLine("addition: " + (x + y));
            Console.WriteLine("division: " + (x / y));
            Console.WriteLine("multiplication: " + (x * y));
            Console.WriteLine("subtraction: " + (x/y));

            //logical operators
            Console.WriteLine("Greater than: " + (x > y));
            Console.WriteLine("Less than: " + (x < y));
            Console.WriteLine("Equal To: " + (x == y));
            Console.WriteLine("Not Equal to: " + (x != y));

            //conditional operators
            Console.WriteLine("AND operator: " + (x > 0 && y > 0));
            Console.WriteLine("OR operator: " + (x > 0 || y > 0));
            Console.WriteLine("NOT Operator: " + !(x > 0 && y > 0));

            //prefix and postfix operators
            Console.WriteLine("Prefix Operator, ++x: " + (++x));
            Console.WriteLine("Postfix Operator, x++: " + (x++));

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            //classes
            Person person1 = new Person("Arjun", 20);
            person1.PrintInfo();

            //static class
            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}