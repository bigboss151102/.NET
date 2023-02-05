namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte) i;
            System.Console.WriteLine(b);

            var number = "1234";
            int j = Convert.ToInt32(number);
            System.Console.WriteLine(i);


            try
            {
                var number1 = "1234";
                byte f = Convert.ToByte(number1);
                System.Console.WriteLine(f);
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("The number counld not be converted to a byte !");
            }


            
            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("The number counld not be converted to a byte !");
            }
        }
    }
}