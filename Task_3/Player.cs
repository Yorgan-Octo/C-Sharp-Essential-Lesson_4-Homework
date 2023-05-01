using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Player : IPlayable, IRecodable
    {

        void IPlayable.Play()
        {
            Console.WriteLine("НАчало проигрования");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза проигрования");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Остановка проигрования");
        }



        void IRecodable.Record()
        {
            Console.WriteLine("Начало записи");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза записи");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Остановка записи");
        }



    }
}
