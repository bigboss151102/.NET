namespace CSharpFundamental
{
    public class Person
    {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
           var number = 1;
           Increment(number);
           System.Console.WriteLine(number);

           Person person = new Person() {age = 20};
           MakeOld(person);
           System.Console.WriteLine(person.age);
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}