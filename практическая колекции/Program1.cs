using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Queue<string> очередь = new Queue<string>();
            очередь.Enqueue("Анна");
            очередь.Enqueue("Пётр");
            очередь.Enqueue("Ольга");
            очередь.Enqueue("Иван");
            очередь.Enqueue("Мария");
            Console.Write("В очереди находятся: ");
            Console.WriteLine(string.Join(", ", очередь.ToArray()));
            while (очередь.Count > 0)
            {
                string элемент = очередь.Dequeue();
                Console.WriteLine("Обслуживаем: " + элемент);
            }
            Console.WriteLine("Очередь закончилась");
        }
    }
    
}
