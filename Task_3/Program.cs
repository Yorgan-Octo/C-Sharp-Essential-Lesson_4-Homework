using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Player player = new Player();



            string userIn;
            while (true)
            {
                Console.WriteLine("Запис або відтворенн 1 - запис; 2 - відтворення;");
                Console.Write("Ваш вибір: ");
                userIn = Console.ReadLine();

                if (userIn != "1" && userIn != "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такого пункта меню не мае!");
                    Console.ResetColor();
                    continue;
                }

                break;
            }

            switch (userIn)
            {
                case "1":
                    {
                        IRecodable recodable = player;
                        Console.WriteLine(new String('=', 50));
                        recodable.Record();
                        Console.WriteLine(new String('-', 50));
                        recodable.Pause();
                        Console.WriteLine(new String('-', 50));
                        recodable.Stop();
                        Console.WriteLine(new String('=', 50));
                        break;
                    }
                case "2":
                    {
                        IPlayable playable = player;
                        Console.WriteLine(new String('=',50));
                        playable.Play();
                        Console.WriteLine(new String('-', 50));
                        playable.Pause();
                        Console.WriteLine(new String('-', 50));
                        playable.Stop();
                        Console.WriteLine(new String('=', 50));
                        break;
                    }
            }


            Console.ReadKey();
        }
    }
}
