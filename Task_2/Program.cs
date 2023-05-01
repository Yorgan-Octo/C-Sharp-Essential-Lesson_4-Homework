using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя документа: ");
            string nameDocement = Console.ReadLine();

            AbstractHandler handler = null;

            Console.Clear();
            while (true)
            {
                Console.Write("Віберіть формат бокумента: ");
                string createDocement = Console.ReadLine().ToUpper();
                if (createDocement.ToUpper() == "DOC") { handler = new DOCHandler(nameDocement); break; }
                else if (createDocement.ToUpper() == "TXT") { handler = new TXTHandler(nameDocement); break; }
                else if (createDocement.ToUpper() == "XML") { handler = new XMLHandler(nameDocement); break; }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    ColorMesShow("Такого формата не існуе! спробуйте ще раз", ConsoleColor.Red);
                    Console.ResetColor();
                }
            }

            if (handler != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                handler.Create();
                Console.ResetColor();
            }

            while (true)
            {



                int menuButton;
                while (true)
                {
                    try
                    {
                        Console.WriteLine(new String('=',50));
                        Console.WriteLine("Меню: 1 - відкритифайл; 2 - відредагувати файл;");
                        Console.WriteLine(new String('=', 50));

                        Console.Write("Виберіть пункт меню: ");
                        menuButton = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        ColorMesShow("НЕправильний пункт меню!", ConsoleColor.Red);
                    }
                }



                if (menuButton == 1 && handler != null)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    handler.Open();
                    Console.ResetColor();
                    handler.discriptionShow();

                    ColorMesShow("натисныть на будь яку кнопку щоб продойжити!", ConsoleColor.Green);
                    Console.ReadKey();
                    Console.Clear();
                }

                if (menuButton == 2 && handler != null)
                {
                    Console.Clear();

                    Console.WriteLine("Введіть текст для додавання у файл:");
                    Console.Write("Текcт: ");

                    string addText = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    handler.Change();
                    Console.ResetColor();

                    Console.WriteLine("Зьерегти файл 1 - так; 2 - ні:");
                    int seveButton = int.Parse(Console.ReadLine());

                    if (seveButton == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        handler.Save();
                        Console.ResetColor();
                        handler.Discriptsin = addText;
                    }
                }
            }


            //можна булоб просто визвати вси ци методи та все
            //if (handler != null)
            //{
            //    Console.Clear();
            //    Console.WriteLine(new String('-', 50));
            //    handler.Create();
            //    handler.Open();
            //    handler.Change();
            //    handler.Save();
            //    Console.WriteLine(new String('-', 50));
            //}
        }


        static void ColorMesShow(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
}
