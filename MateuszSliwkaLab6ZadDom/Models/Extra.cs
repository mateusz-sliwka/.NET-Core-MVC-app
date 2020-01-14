using System;
namespace MateuszSliwkaLab6.Models
{

    public class Extra
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Extra(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
