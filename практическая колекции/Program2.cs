using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Введите строки для добавления в стек (пустая строка для завершения):");
            string input;
            while (true) 
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) 
                {
                    break; 
                }
                stack.Push(input);
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Стек пуст.");
            }
            else
            {
                Console.WriteLine("Содержимое стека (от вершины к основанию):");
                foreach (string item in stack.ToArray())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}