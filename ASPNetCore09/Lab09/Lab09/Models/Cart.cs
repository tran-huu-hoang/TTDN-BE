﻿namespace Lab09.Models
{
    public class Cart
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Total { get; set; }
    }
}
