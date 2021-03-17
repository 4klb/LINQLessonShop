using LINQLessonShop.DataAccess;
using LINQLessonShop.Models;
using LINQLessonShop.Services;
using LINQLessonShop.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLessonShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                var webpage = new Webpage();
                webpage.Menu();
            }
        }
    }
}
