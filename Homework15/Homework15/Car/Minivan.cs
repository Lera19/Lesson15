﻿namespace Homework15
{
    public class Minivan : Car
    {
        public Minivan(string color, int price, string name) : base(color, price, name)
        {
            Color = color;
            Price = price;
            Name = name;
        }
        public new string Color { get; set; }

        public new int Price { get; set; }

        public new string Name { get; set; }

    }
}
