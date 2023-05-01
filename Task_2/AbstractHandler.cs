using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class AbstractHandler
    {

        private string name;

        private string discriptsin;
        public string Name
        {
            get
            {
                if (name == null || name == "")
                {
                    return "Новий фал";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Discriptsin
        {
            get
            {
                if (discriptsin == null)
                {
                    return "Тут посто! Відредагуйте файл";
                }
                return discriptsin;
            }
            set
            {
                discriptsin = value;
            }
        }
        public AbstractHandler(string name)
        {
            this.name = name;
        }

        public abstract void Open();

        public abstract void Create();

        public abstract void Change();

        public abstract void Save();

        public void discriptionShow()
        {
            Console.WriteLine("Текст фала:");
            Console.WriteLine(new String('=', 70));
            Console.WriteLine(Discriptsin);
            Console.WriteLine(new String('=', 70));
        }

    }
}
