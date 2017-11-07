using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyPython
{
    /// <summary>
    /// Программа выводит в консоль числа от 1 до 100, причём числа, кратные 3, заменяются словом Monty,
    /// числа, кратные 5, заменяются словом Python, числа, кратные 15, заменяются словом MontyPython.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) Console.Write("MontyPython ");
                else
                if (i % 3 == 0) Console.Write("Monty ");
                else
                if (i % 5 == 0) Console.Write("Python ");
                else
                    Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
