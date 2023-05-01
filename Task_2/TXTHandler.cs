using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class TXTHandler : AbstractHandler
    {

        public TXTHandler(string name) : base(name) { }

        public override void Create()
        {
            Console.WriteLine($"Создан документ формата {Name}.txt");
        }

        public override void Open()
        {
            Console.WriteLine($"Открит документ формата {Name}.txt");
        }


        public override void Change()
        {
            Console.WriteLine($"Изменен документ формата {Name}.txt");
        }

        public override void Save()
        {
            Console.WriteLine($"Сохрвнен документ формата {Name}.txt");
        }

    }
}
