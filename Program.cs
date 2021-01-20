using System;

namespace ex15pool1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            if(a>b && a>c && b>c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);

                Console.WriteLine(c);


            }
        }
    }
}
