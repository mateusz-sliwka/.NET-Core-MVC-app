using System;
using System.Collections.Generic;

namespace MateuszSliwkaLab6.Models
{
    public static class CarOrder
    {
        public static CarTypeModel Model { get; set; }
        public static Extra Engine { get; set; }
        public static Extra Transmission { get; set; }
        public static Extra Drive { get; set; }
        public static List<Extra> Extras = new List<Extra>();
        public static Client Owner { get; set; }
        public static int Price;

        public static void reCalculate()
        {
            Price += Model.Price;
            Price += Engine.Price;
            Price += Transmission.Price;
            Price += Drive.Price;
            foreach(Extra e in Extras)
            {
                Price += e.Price;
            }
        }
       
    }
}
