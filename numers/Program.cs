using System;

namespace numers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            var o = Convert.ToInt32(Console.ReadLine());
            var numbers = IntToNumbers(o).OrderByDescending(x => x);

            var result = 0;
            var size = numbers.Count();
            foreach (var h in numbers)
            {
                result *= 10;
                result += h;
            }
            result *= result;
            Console.WriteLine(result);
            Console.WriteLine("_______________");
           

            static List<int> IntToNumbers(int o)
            {
                o = Math.Abs(o);
                var numbers = new List<int>();
                while (o > 0)
                {
                    int number = o % 10;
                    o /= 10;
                    numbers.Add(number);
                }
                return numbers;
            }



                Console.WriteLine("2.");
                var u = Convert.ToInt32(Console.ReadLine());

                var res = u / 10;
                res %= 100;

                Console.WriteLine(res);
                Console.WriteLine("________________");



                Console.WriteLine("4.");
            var t = Console.ReadLine();

            t = t.Replace("0", string.Empty)
                 .Replace("2", string.Empty)
                 .Replace("4", string.Empty)
                 .Replace("6", string.Empty)
                 .Replace("8", string.Empty);

            t = t.Length > 0 ? t : "0";
            Console.WriteLine(t);
            Console.WriteLine("________________");



            Console.WriteLine("5.");          
            var g = Convert.ToInt32(Console.ReadLine());
            int l;
            if (g >= 10_000 && g < 100_000)
            {
                l = (g / 1000) * 100 + g % 100;
            }
            else 
            {
                l = g;
            }
            Console.WriteLine(l);
                  
        }
    }
}