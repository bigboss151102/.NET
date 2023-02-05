namespace CSharpFundementals
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hoang";
            string lastName = "Trong";

            string fullName = firstName + " " + lastName; // string or var

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(myFullName);

            var names = new string[3] {"Hoang","Cong","Trong"};
            var formatedNames = string.Join("-",names);
            System.Console.WriteLine(formatedNames);

            var text1 = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text2 = @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            System.Console.WriteLine(text1);
            System.Console.WriteLine(text2);

        }
    }
}