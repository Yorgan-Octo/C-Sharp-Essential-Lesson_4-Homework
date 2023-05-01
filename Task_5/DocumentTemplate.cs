using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal abstract class DocumentTemplate
    {

        private string content;

        public string Content
        {
            protected get
            {
                if (content != null)
                    return content;

                return "Заголовок відсутній.";
            }
            set
            {
                content = value;
            }
        }

        public abstract void Show();

    }
}
