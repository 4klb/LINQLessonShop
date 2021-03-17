using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLessonShop.Models
{
    public class CatalogPositions : Entity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
