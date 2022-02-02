// <copyright file="Basket.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW2
{
    using System;
    using System.Collections.Generic;

    internal class Basket
    {
        private readonly List<Product> _products;
        private readonly Random _random = new Random();

        public Basket(List<Product> productToOrder) => _products = productToOrder;

        public int Id => _random.Next(123456, 789012);
        public List<Product> Products { get => _products; }

        public decimal Total()
        {
            decimal summa = 0;
            foreach (var item in _products)
            {
                summa += item.Price;
            }

            return summa;
        }
    }
}
