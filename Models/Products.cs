﻿namespace PPKomerc.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int Price { get; set; }
        public int Stock  { get; set; }

        public Products()
        {

        }
    }
}
