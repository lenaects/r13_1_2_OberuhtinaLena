using System;
using System.Collections;

namespace pract13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("Введите количество элеменнтов");
                    int n = int.Parse(Console.ReadLine());
                    ArrayList list = new ArrayList();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine((i + 1) + "элемент");
                        list.Add(Console.ReadLine());

                    }
                    foreach (object i in list)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Введите сколько элементов удалить");
                    int k = int.Parse(Console.ReadLine());
                    int N = n / 2;
                    while (k != 0)
                    {
                        list.RemoveAt(N);
                        k--;
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    break;



                }
                catch
                {
                    Console.WriteLine("некоректнно введенно");
                }
            
            }

            Console.ReadLine();
        }
    }
}
