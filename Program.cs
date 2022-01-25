using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        class complex
        {
            private int a, b;
            public void set(int x, int y)
            {
                a = x; b = y;
            }
            public void show()
            {
                Console.WriteLine($"a is : {a}");
                Console.WriteLine($"b is :{b}");
            }
            public static complex operator +(complex x1, complex x2)
            {
                complex temp = new complex(); ;
                temp.a = x1.a + x2.a;
                temp.b = x1.b + x2.b;
                return temp;
            }
            public static complex operator -(complex x1, complex x2)
            {
                complex temp = new complex(); ;
                temp.a = x1.a - x2.a;
                temp.b = x1.b - x2.b;
                return temp;
            }
        }
        static void Main(string[] args)
        {
            complex c1 = new complex();
            complex c2 = new complex();
            c1.set(7, 9);
            c2.set(8, 10);
            complex c3 = c1 + c2;
            c3.show();
            c3 = c2 - c1;
            c3.show();

        }
    }
}
