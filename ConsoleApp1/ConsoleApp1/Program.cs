using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            
                int flag = 0;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] == a[i - 1])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1) Console.WriteLine("В строке имеются два соседствующих одинаковых символа");
                else Console.WriteLine("В строке не имеется два соседствующих одинаковых символа");
            
        }
    }
}
