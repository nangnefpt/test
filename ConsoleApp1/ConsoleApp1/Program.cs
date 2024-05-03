internal class Program
{
    private static void Main(string[] args)
    {
      
        Console.WriteLine("Hello, World!");
        Person person = new Person("Nang", 21) ;
        person.Introduce();
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Xin chào, tôi là {Name} và tôi {Age} tuổi.");
        }
    }
}