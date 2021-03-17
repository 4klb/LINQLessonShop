using LINQLessonShop.DataAccess;
using LINQLessonShop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLessonShop.Services
{
    public class KeyboardService
    {
        public ConsoleKeyInfo CatchKey { get; set; }

        public int Key { get; set; }

        public List<string> List { get; set; }

        public string ProductChoice { get; set; }
        public int CurrentPage { get; set; }

        public int KeyboardListen()
        {
            string status = string.Empty;

            int key;

            var webpage = new Webpage();

            do
            {
                CatchKey = Console.ReadKey();

                Move(CatchKey.Key);

                status = CatchKey.KeyChar.ToString();

                int.TryParse(status, out key);

                Key = key;


            } while (CatchKey.Key != ConsoleKey.Backspace);

            return Key;
        }

        public void Move(ConsoleKey keyDirection)
        {
            var itemsData = new ItemDataAccess();
            var webpage = new Webpage();

            int сursorPosition = Console.CursorTop;

            switch (keyDirection)
            {
                case ConsoleKey.UpArrow:
                    if (Console.CursorTop > 0)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                    }
                    else if (Console.CursorTop == 0)
                    {
                        Console.SetCursorPosition(0, 0);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Console.CursorTop < Console.BufferHeight)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                    }
                    break;
                case ConsoleKey.Enter:
                    ProductChoice = itemsData.SelectItemChoice(List, сursorPosition);
                    break;
                case ConsoleKey.Tab:
                    webpage.DrawPurchase(ProductChoice);
                    break;
                case ConsoleKey.Escape:
                    webpage.Menu();
                    break;
                case ConsoleKey.R:
                    List = itemsData.SelectByRaiting();
                    break;
                case ConsoleKey.RightArrow:
                    ++CurrentPage;
                    Console.SetCursorPosition(0, 1);
                    List = itemsData.SelectAllItems(CurrentPage, сursorPosition);
                    break;
                case ConsoleKey.LeftArrow:
                    --CurrentPage;
                    Console.SetCursorPosition(0, 1);
                    List = itemsData.SelectAllItems(CurrentPage, сursorPosition);
                    break;
                default:
                    break;
            }
        }
    }
}
