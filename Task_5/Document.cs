using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Document
    {

        Title title;
        Body body;
        Footer footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            Console.WriteLine(new String('=',50));
            this.title.Show();
            this.body.Show();
            this.footer.Show();
            Console.WriteLine(new String('=', 50));
        }

    }
}
