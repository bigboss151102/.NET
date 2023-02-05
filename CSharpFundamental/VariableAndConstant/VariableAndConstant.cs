namespace Variable
{
    class Variable
    {
        static void Main(string[] args)
        {
        //    byte number = 2;
        //    int count = 10;
        //    float totalPrice = 20.95f;
        //    Char character = 'A';
        //    string firstName = "Trong";
        //    bool isWorking = false;


        var number = 2;
        var count = 10;
        var totalPrice = 20.95f;
        var character = 'a';
        var firstName = "Trong";
        var isWorking = false;

           System.Console.WriteLine(number);
           System.Console.WriteLine(count);
           System.Console.WriteLine(totalPrice);
           System.Console.WriteLine(character);
           System.Console.WriteLine(firstName);
           System.Console.WriteLine(isWorking);

           System.Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
           System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
           System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

           const float PI = 3.14f;
           System.Console.WriteLine(PI);
        }
    }
}