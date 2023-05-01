using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тіло контракту...";

            Footer footer = new Footer();
            footer.Content = "Директор: Іванов І.І.";

            Document document = new Document(title, body, footer);
            document.Show();

            Console.ReadKey();

        }
    }
}
