using LINQLessonShop.DataAccess;
using LINQLessonShop.Models;
using LINQLessonShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQLessonShop.UI
{
    public class Webpage
    {
        public void DrawPageItems(List<string> items, int currentPage, int itemsCount)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 12);

            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Товары");

            foreach (var item in items)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"  Наименование товара: {item}");
            }

            Console.SetCursorPosition(1, 13);
            Console.WriteLine($" Текущая страница {currentPage} (<-/->)");

            Console.SetCursorPosition(1, 15);
            Console.WriteLine(" Отсортировать товары по популярности (нажмите R)");

            Console.SetCursorPosition(32, 19);
            Console.WriteLine($" Всего {itemsCount} продуктов");
            Console.SetCursorPosition(1, 1);

        }

        public void DrawByRaiting(List<string> raiting, int currentPage)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 12);

            Console.SetCursorPosition(2, 0);
            Console.WriteLine(" Топ 10 товаров");

            foreach (var item in raiting)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"  Наименование товара: {item}");
            }

            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" Чтобы выбрать страницу нажмите ( -> )");

            Console.SetCursorPosition(1, 1);
        }

        public void Menu() //Escape
        {
            Console.Clear();
            var keyboardService = new KeyboardService();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(" Стартовая страница");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine(" Отсортировать товары по популярности (нажмите R)");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine(" Чтобы выбрать страницу нажмите ( -> )");
            keyboardService.KeyboardListen();
        }

        public void DrawPurchase(string productChoice) //Tab
        {
            Console.Clear();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Страница покупки товара");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine($"Ваш выбор {productChoice}");
            Console.WriteLine();
            Console.WriteLine(" Чтобы вернуться к выбору страниц нажмите (<-/->)");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine(" Нажмите любую клавишу чтобы перейти к Qiwi-касса");
            Console.ReadKey();
            //оплата, процесс уменьшения товара со склада 
        }
    }
}
