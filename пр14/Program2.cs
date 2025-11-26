using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }
    class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }
    class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();
        }
    }
}
