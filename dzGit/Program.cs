using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            do
            {
                Console.WriteLine("Введите число ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень, в которую необходимо возвести число ");
                int pow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат "+Math.Pow(num, pow));
                Console.WriteLine("Нажмите 0 для повтора ");
                again = Console.ReadLine();
            } while (again == "0");
        }
    }
}
