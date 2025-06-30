namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
           return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
           int moneySum = a + b;
           //bool dollars = true;
           //if (true)
           {
               //return $"{moneySum} dollars";
           }
           //else
           {
               //return $"{moneySum} dollar";
           }
            if (c == true && moneySum > 1)
            {
                return $"{moneySum} dollars";
            }
            if (c == true && moneySum < -1)
            {
                return $"{moneySum} dollars, Yikes!";
            }
            if (c == true && moneySum == 1)
            {
                return $"{moneySum} dollar";
            }
            if (c == true && moneySum == -1)
            {
                return $"{moneySum} dollar";
            }
            if (c == true && moneySum == 0)
            {
                return $"{moneySum} dollars? You're broke!";
            }
            else
            {
                return moneySum.ToString();
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Add(1,2,true);
            var x = 10;
            var y = 15;
            var answer = Add(x, y);

            var a = 5.5m;
            var b = 7.2m;
            var answer2 = Add(a,b);

            var answer3 = Add(0, 1, true);
            
            Console.WriteLine($"int add : {answer}");
            Console.WriteLine($"decimal add : {answer2}");
            Console.WriteLine(answer3);
        }
    }
}
