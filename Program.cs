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
        /* public static int Factorial(int a)
        {
            if (a == 0 || a == 1){
                return 1;
            }
            return a*Factorial(a-1);
        } */

        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
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

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            //control structures
            Console.WriteLine("Control Structures");

            //if else
            Console.WriteLine("If-Else");
            Console.Write("Enter the hour: ");
            int hour = int.Parse(Console.ReadLine());

            if (hour > 10)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Morning");
            }

            // if-else if - else
            Console.WriteLine("If-Else If-Else");
            Console.Write("Enter the hour: ");
            hour = int.Parse(Console.ReadLine());

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }

            // switch case
            Console.WriteLine("Switch Case");
            Console.Write("Enter your selection (1 or 2): ");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("First");
                    break;
                case 2:
                    Console.WriteLine("Second");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            // conditional operator
            Console.WriteLine("Conditional Operator");
            Console.Write("Are you a gold customer? (true or false): ");
            bool isGoldCustomer = bool.Parse(Console.ReadLine());
            string boolResult = isGoldCustomer == true ? "Gold" : "Silver";

            Console.WriteLine(boolResult); */
            /* Console.WriteLine("Enter a number:");
            var number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10){
                Console.WriteLine("Valid Number");
            }
            else{
                Console.WriteLine("Invalid Number");
            }

            Console.WriteLine("Enter two numbers: ");
            Console.WriteLine("Number1: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            var number2 = int.Parse(Console.ReadLine());

            var isGreater = number1 > number2 ? "Number 1 is greater" : "Number 2 is greater.";
            Console.WriteLine(isGreater);
            
            Console.WriteLine("width: ");
            var width = float.Parse(Console.ReadLine());
            Console.WriteLine("height: ");
            var height = float.Parse(Console.ReadLine());

            var result = height > width ? "Potrait" : "Landscape";
            Console.WriteLine(result);

            Console.WriteLine("Enter speed limit");
            var speedLimit = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed of car:");
            var carSpeed = float.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit){
                Console.WriteLine("OK");
            }

            var diff = carSpeed - speedLimit;
            var points = diff/5;

            if (points > 12){
                Console.WriteLine("License Suspended");
            }
            else{
                var intPoints = (int)points;
                Console.WriteLine(intPoints);
            } */
            //iterations
            /* Console.WriteLine("ForEach iteration");
            var myArray = new int[3]{0,1,2};
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("For Loop");
            for (int i = 0; i < myArray.Length; i++){
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("while loop");
            int x = 0;
            while(x < myArray.Length){
                Console.WriteLine(myArray[x]);
                x++;
            }
            int y = 0;
            Console.WriteLine("do while");
            do
            {
                Console.WriteLine(myArray[y]);
                y++;
            } while (y < myArray.Length); */
            /* var random = new Random();
            Console.WriteLine("random number" + "rand no with range: " + "random alphabet");
            for (var i=0;i<10;i++){
                Console.WriteLine(random.Next() + " " + random.Next(1,20) + " " + (char)random.Next(97,122));
            } */
            /* var no = 0;
            for (int i = 1; i <= 100; i++){
                if (i%3 == 0){
                    Console.WriteLine(i);
                    no++;
                }
            }
            Console.WriteLine(no); */
            /* var sum = 0;
            while(true){
                Console.WriteLine("Enter any number you want (type ok for exit)?");
                var input = Console.ReadLine();
                if (input == "ok"){
                    Console.Beep();
                    break;
                }
                sum += int.Parse(input);
            }
            Console.WriteLine(sum); */
            /* int result = Factorial(5);
            Console.WriteLine("Factorial of 5: "+ result); */
            /* var random = new Random();
            var num = random.Next(1,10);
            var i = 0;
            Console.WriteLine("Let's play a game.");
            Console.WriteLine("You have 4 turns. guess the number.");
            while(i<4){
                var number = int.Parse(Console.ReadLine());
                if (number == num){
                    Console.WriteLine("U got it!");
                    break;
                }
                i++;
            }
            if (i >= 4){
                Console.WriteLine("You lost! The number was: " + num);
            } */
            /* var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("hour: " + now.Hour);
            Console.WriteLine("minute: " + now.Minute);
            Console.WriteLine("hour: " + today);
            Console.WriteLine("hour: " + dateTime);

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("hour: " + tommorow.Day);
            Console.WriteLine("minute: " + tommorow.ToLongDateString());
            Console.WriteLine("minute: " + tommorow.ToShortDateString());
            Console.WriteLine("lol: " + yesterday.ToLongTimeString());
            Console.WriteLine("lol: " + yesterday.ToShortTimeString());
            Console.WriteLine("lol: " + now.ToString("dd mm yyyy")); */
            /* var timespan = new TimeSpan(1,2,3);

            var timespan1 = new TimeSpan(1,0,0);
            var timespan2 = TimeSpan.FromHours(1);

            Console.WriteLine(timespan + " " + timespan1 + " " + timespan2);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);      */
               
        }
    }
}