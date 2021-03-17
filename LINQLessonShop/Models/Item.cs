using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLessonShop.Models
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Raiting { get; set; }

        //public Guid CategoryId { get; set; }
        //public Category Category { get; set; }
        //public Guid CountryId { get; set; }
        //public Country Country { get; set; }
    }
}
