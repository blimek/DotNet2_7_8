using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć. Napisz ile punktów dostałeś na maturze z matematyki ?");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ile punktów dostałeś na maturze z fizyki ?");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ile punktów dostałeś na maturze z chemi?");
            int c= Int32.Parse(Console.ReadLine());
            
            
            if((a > 70 && b > 55 && c > 45 && a+b+c > 180) || (a + b > 150) || (a + c > 150))
            {
                Console.WriteLine("Brawo zostałeś dopuszczony do rekrutacji na studia");

            }
            else
            {
                Console.WriteLine("Niestety nie zostałeś dopuszczony do rekrutacji");

            }
            Console.ReadLine();

        }
    }
}
