using Anton;
using System;

namespace Prokopenko
{
    class Program
    {     
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите параметры: ");
                float a = Int32.Parse(Console.ReadLine());
                float b = Int32.Parse(Console.ReadLine());
                float c = Int32.Parse(Console.ReadLine());
                ProkopenkoLog.I().log($"Введено уравнение: {a}x^2 + {b}x + {c} = 0");
                Solve_x2 Yow = new Solve_x2();
                ProkopenkoLog.I().log("Корни уравнения " + String.Join("; ", Yow.Solve(a, b, c)));
            }
            catch (ProkopenkoException ex)
            {
                ProkopenkoLog.I().log(ex.Message);
            }
            ProkopenkoLog.I().write();
        }
    }
}
