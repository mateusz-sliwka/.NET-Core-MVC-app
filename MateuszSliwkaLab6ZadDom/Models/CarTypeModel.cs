using System;
using System.Collections.Generic;

namespace MateuszSliwkaLab6.Models
{
    public class CarTypeModel
    { 
        //Model samochodu
        public string Model { get; set; }
        //Ilosc miejsc
        public int CarSeats { get; set; }
        //Opis rodzaju auta
        public string Description { get; set; }
        //Cena podstawy
        public int Price { get; set; }
        //Sciezka do zdj auta
        public string Photo { get; set; }
        public List<string> AvailableMotors { get; set; }
     
        //Konstruktor klasy
        public CarTypeModel(string model, int carSeats, string decription,int price, string photo,List<string> motors)
        {
            Model = model;
            CarSeats = carSeats;
            Description = decription;
            Price = price;
            Photo = photo;
            AvailableMotors =motors;
        }
    }
}