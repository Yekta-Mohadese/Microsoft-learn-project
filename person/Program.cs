public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Mohadese", 21);
        person1.PrintInfo();
        Person person2 = new Person("Mohamad", 21);
        person2.PrintInfo();
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string aName, int aAge)
    {
        Name = aName;
        Age = aAge;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age} good to see you dear {Name }");
    }

}
 