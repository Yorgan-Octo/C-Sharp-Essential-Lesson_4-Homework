using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Document
    {
        Title title = null;
        Body body = null;
        Footer footer = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
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
