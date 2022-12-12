using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string b = Console.ReadLine();
            StringBuilder a = new StringBuilder(b);
            Console.Write("Введите символ: ");
            string ch = Console.ReadLine();
            if (ch == "" || ch == " ") Console.WriteLine("Вы не ввели символ");
            else
            {

                string[] c = b.Split(' ', ',', '?', ';', '.', '!');


                foreach (string item in c)
                {
                    int vv = item.IndexOf(ch.ToUpper());
                    int xx = item.IndexOf(ch.ToLower());
                    if (item.IndexOf(ch.ToUpper()) != -1 || item.IndexOf(ch.ToLower()) != -1)
                    {
                        int fl = b.IndexOf(item);
                        a.Remove(fl, item.Length);
                        b = a.ToString();

                    }
                }
                b = b.Trim();

                Console.WriteLine(b);
            }  
        }
    }
}
