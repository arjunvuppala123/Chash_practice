namespace HelloWorld
{
    class Person
    {
        public string name;
        public int age;
    
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }
    
        public void PrintInfo(){
            Console.WriteLine("Name is " + name + " and age is " + age + "years old.");
        }
    }
}