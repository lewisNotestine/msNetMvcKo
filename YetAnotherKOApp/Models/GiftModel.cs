using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YetAnotherKOApp.Models
{
    [Serializable]
    public class GiftModel : IGiftModel
    {
        private GiftModel(string title, double price)
        {
            _title = title;
            _price = price;
        }

        public static IGiftModel Create(string title, double price)
        {
            return new GiftModel(
                title: title,
                price: price);
        }

        private readonly string _title;
        public string Title { get { return _title; } }

        private readonly double _price;
        public double Price { get { return _price; } }
    }
}