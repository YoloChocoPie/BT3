using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            HLine(10, '*'); Console.WriteLine();
            HLine(10, 'a'); Console.WriteLine();
            HLine(10, 'b'); Console.WriteLine();

            VLine(10, '*'); Console.WriteLine();

            DLine(1,  '*'); Console.WriteLine();
            DLine(2,  '*'); Console.WriteLine();
            DLine(3,  '*'); Console.WriteLine();
            DLine(4,  '*'); Console.WriteLine();

            DrawTriangle(10, '*');

        }

        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }

        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }

        static void DLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                HLine(i, ' ');
                Console.WriteLine(" " + c);
        }

        static void DrawTriangle(int n, char c) 
        {
            
                // first line 
            HLine(n - 1, ' '); 
            HLine(1, c); 
            Console.WriteLine();
            int a = 2, b = 1;
            for (int i = 0; i < n - 2; i++)
            {
                HLine(n - a, ' ');
                HLine(1, '*');
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                // fifth line
                a = a + 1;
                b = b + 2;
            }
                // last line
            HLine(2 * n - 1, '*'); Console.WriteLine();
        }
        
            

    }
}
