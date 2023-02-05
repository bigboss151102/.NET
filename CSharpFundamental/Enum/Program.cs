namespace CSharpFundamental
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2 ,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            var methodoId = 3;
            System.Console.WriteLine((ShippingMethod)method);

            System.Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            System.Console.WriteLine(shippingMethod);

        }
    }
}