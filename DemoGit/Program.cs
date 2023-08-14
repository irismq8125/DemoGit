using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            if (Math.Sqrt(n) % 1 == 0)
            {
                Console.WriteLine("{0} la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so chinh phuong", n);
            }
            //code moi cap nhat tren github
            //push code with git command
            Console.ReadKey();
        }
    }
}
