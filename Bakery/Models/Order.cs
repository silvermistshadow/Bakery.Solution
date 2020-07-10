using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        private static List<Order> _instances = new List<Order>();
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }

        public Order(string title, string description)
        {
            Title = title;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public Order(string title, string description, string date, string price)
        {
            Title = title;
            Description = description;
            Date = date;
            Price = price;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}