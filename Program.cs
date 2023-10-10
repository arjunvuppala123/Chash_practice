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
        }
    }
}