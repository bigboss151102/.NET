using System;
namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            System.Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }

    public class Caculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Hoang";
            person.lastName = "Trong";
            person.Introduce();

            Caculate caculate = new Caculate();
            int result = caculate.Add(1,5);
            System.Console.WriteLine(result);
        }
    }
}