using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLessonShop.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; } //у какой-то категории много товаров
    }
}
