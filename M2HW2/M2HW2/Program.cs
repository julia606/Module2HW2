// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW2
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static Dictionary<int, string> GetYourProducts()
        {
            return new Dictionary<int, string>()
            {
                { 1, "Апельсиновый сок Sandora" },
                { 2,  "Овсяные хлопья Elovena без глютена" },
                { 3,  "Оливковое масло Olio Dante Extra Virgin" },
                { 4,  "Конфеты Raffaello" },
                { 5, "Соус Barilla Песто Дженовезе" },
                { 6, "Колбаса сыровяленая Discovery Salame высшего сорта" },
                { 7, "Чипсы Pringles Original" },
                { 9, "Ананас кольцами Tropic Life" },
                { 8, "Тунец Coloso в оливковом масле" },
                { 10, "Шпроты Diplomats рижские в масле" },
            };
        }

        public static Dictionary<string, decimal> GetProductsWithPrice()
        {
            return new Dictionary<string, decimal>()
            {
                { "Апельсиновый сок Sandora", 35 },
                { "Овсяные хлопья Elovena без глютена", 120 },
                { "Оливковое масло Olio Dante Extra Virgin", 198 },
                { "Конфеты Raffaello", 78 },
                { "Соус Barilla Песто Дженовезе", 64 },
                { "Колбаса сыровяленая Discovery Salame высшего сорта", 236 },
                { "Чипсы Pringles Original", 69 },
                { "Ананас кольцами Tropic Life", 54 },
                { "Тунец Coloso в оливковом масле", 85 },
                { "Шпроты Diplomats рижские в масле", 77 },
            };
        }

        public static List<Product> AddProducts(List<Product> productsList, int count)
        {
            int[] arrayOfKey = new int[count];
            for (int i = 0; i < count; i++)
            {
                bool result = int.TryParse(Console.ReadLine(), out arrayOfKey[i]);
                if (result == false || arrayOfKey[i] < 0 || arrayOfKey[i] > 10)
                {
                    Console.WriteLine("Проверьте ввод,что-то пошло нет так");
                    break;
                }
                else
                {
                    _ = Program.GetYourProducts().TryGetValue(arrayOfKey[i], out string product);
                    _ = Program.GetProductsWithPrice().TryGetValue(product, out decimal price);
                    productsList.Add(new Product(product, price));
                }
            }

            return productsList;
        }

        public static void MakeOrder(Basket basket)
        {
            List<Product> order = basket.Products;
            Console.WriteLine($"Номер заказа: {basket.Id}");
            foreach (var item in order)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Итог: {basket.Total()}");
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Введите номер продукта по списку,который хотите приобрести(каждый с новой строки):");
            Console.WriteLine("1.Апельсиновый сок Sandora\n2.Овсяные хлопья Elovena без глютена\n" +
                "3.Оливковое масло Olio Dante Extra Virgin\n4.Конфеты Raffaello\n" +
                "5.Соус Barilla Песто Дженовезе\n6.Колбаса сыровяленая Discovery Salame высшего сорта\n" +
                "7.Чипсы Pringles Original\n8.Тунец Coloso в оливковом масле\n" +
                "9.Ананас кольцами Tropic Life\n10.Шпроты Diplomats рижские в масле\n");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("              Вас приветствует продуктовый интернет-магазин!");
            Console.WriteLine("\nВведите количество продуктов для покупки:");
            bool result = int.TryParse(Console.ReadLine(), out int count);
            if (result == false || count > 10 || count < 0)
            {
                Console.WriteLine("Проверьте ввод,что-то пошло нет так");
            }
            else
            {
                List<Product> productsList = new List<Product>();
                PrintInfo();
                var list = AddProducts(productsList, count);
                Console.WriteLine("Сформировать корзину: введите 1\nДобавить товары в корзину: введите 2\n" +
                    "Офоhмить заказ окончательно: введите 3");
                bool check = true;
                while (check)
                {
                    bool res = int.TryParse(Console.ReadLine(), out int operation);
                    if (res)
                    {
                        switch (operation)
                        {
                            case 1:
                                Basket basket = new Basket(list);
                                Console.WriteLine($"Корзина готова,можно сформировать заказ\nВаш заказ из {list.Count} позиций: ");
                                MakeOrder(basket);
                                break;
                            case 2:
                                Console.WriteLine("\nВведите количество продуктов для покупки:");
                                bool additionalResult = int.TryParse(Console.ReadLine(), out int newCount);
                                if (additionalResult)
                                {
                                    AddProducts(productsList, newCount);
                                    Console.WriteLine("Продукт(ы) добавлены в корзину");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка!");
                                }

                                break;
                            case 3:
                                Console.WriteLine("Формируем окончательно заказ...");
                                Basket newBasket = new Basket(list);
                                MakeOrder(newBasket);
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Неверный ввод,повторите попытку!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод,повторите попытку!");
                    }
                }
            }
        }
    }
}
