using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    public enum DeliveryStatus
    {
        Pending = 0,
        Shipped = 1,
        Delivered = 2
    }
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
            // var firstName = "Arjun";
            var isWorking = true;
            var num = 6;

            const float Pi = 3.14f;

            // printing variables
            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(totalPrice);
            // Console.WriteLine(firstName);
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
            Console.WriteLine("subtraction: " + (x / y));

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
            Console.WriteLine("Sum is: " + result);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            //arrays
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var strings = new string[3] { "abc", "def", "ghi" };

            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            //strings
            var firstName = "Arjun";
            var lastName = "Vuppala";

            var fullNamev1 = firstName + " " + lastName;
            var fullNamev2 = string.Format("{0} {1}", firstName, lastName);
            var fullNamev3 = string.Concat(firstName, lastName);

            Console.WriteLine(fullNamev1);
            Console.WriteLine(fullNamev2);
            Console.WriteLine(fullNamev3);

            var firstLetter = firstName[0];
            Console.WriteLine(firstLetter);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var filePathv1 = @"c:\projects\project1\folder1\file1.txt";
            var filePathv2 = "c:\\projects\\project1\\folder1\\file1.txt";
            Console.WriteLine(filePathv1);
            Console.WriteLine(filePathv2);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            //enums
            var status = DeliveryStatus.Delivered;
            Console.WriteLine((int)status);

            var methodId = 2;
            Console.WriteLine((DeliveryStatus)methodId);
            Console.WriteLine(status.ToString());
            Console.WriteLine(status);

            var methodName = "Delivered";
            var deliveryStatus = (DeliveryStatus)Enum.Parse(typeof(DeliveryStatus), methodName);
        
            Console.WriteLine(deliveryStatus);
        }
    }
}