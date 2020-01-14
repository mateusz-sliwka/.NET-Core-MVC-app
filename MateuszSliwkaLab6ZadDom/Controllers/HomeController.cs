using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MateuszSliwkaLab6.Models;
using Microsoft.AspNetCore.Http;

namespace MateuszSliwkaLab6.Controllers
{
    public class HomeController : Controller
    {
        List<CarTypeModel> baseCars; //lista przechowujaca modele bazowe
       
        public HomeController()  //konstruktor kontrolera 
        {
            baseCars = new List<CarTypeModel>(); //stworzenie nowego obiektu listy oferowanych modeli podst
            baseCars.Add(new CarTypeModel("Sprinter", 3, "Bus idealny do transportu", 120000, "~/Images/sprinter.png", new List<string> { "2.0d", "3.0d" })); //uzupelnienie listy
            baseCars.Add(new CarTypeModel("Klasa S", 5, "Limuzyna dla wymagajacych", 250000, "~/Images/sklasa.png",new List<string>{ "S350i","S350d"}));
        }
      
      
        public IActionResult ChooseSpecification(string model) //akcja po wyborze modelu podstawowego
        {
            CarOrder.Model = baseCars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault(); //przypisanie do zamowienia wybranego modelu auta
            ViewBag.Model = CarOrder.Model.Model; //zapisanie do viewbaga modelu ktory bedziemy wyswietlac w tytule
            return View(); //zwrocenie widoku wyboru specyfikacji
        }

        [HttpPost]
        public IActionResult ShowExtras(string choosenEngine, string choosenTransmission, string choosenDrive) //akcja po wyborze specyfikacji
        {
            ViewBag.Model =CarOrder.Model.Model; //przekazanie do viewbaga modelu ktory wyswietlamy w tytule
           CarOrder.Engine = new Extra(choosenEngine.Split('-')[0], Int32.Parse(choosenEngine.Split('-')[1])); //przypisujemy wybrany silnik do atrybutu zamowienia
           CarOrder.Transmission = new Extra(choosenTransmission.Split('-')[0], Int32.Parse(choosenTransmission.Split('-')[1])); //skrzynie tez
            CarOrder.Drive = new Extra(choosenDrive.Split('-')[0], Int32.Parse(choosenDrive.Split('-')[1])); //naped tez
            return View("ChooseExtras"); //zwracamy widok wyboru dodatkow
        }

        [HttpPost]
        public IActionResult ShowOwner(string[] extras) //akcja po wyborze dodatkow
        { 
            if(extras!=null) //sprawdzamy czy wybrano jakies dodatki (przekazane zostaly metoda httppost)
            foreach (string argument in extras) //jezeli tak to iterujemy po nich
                CarOrder.Extras.Add(new Extra(argument.Split('-')[0], Int32.Parse(argument.Split('-')[1]))); //z kazdego tworzymy obiekt i dodajemy jako dodatek zamowienia
            TempData["currentCar"] = CarOrder.Engine.Name; //ustawiamy wartosc tempdata na silnik
            return View("ChooseOwner"); //zwracamy widok wyboru zamawiajacego
        }
        [HttpPost]
        public IActionResult ShowBilling(Client model) //akcja po wyborze zamawiajacego
        {
            CarOrder.Owner = model; //przypisanie obiektu zamaiwjacego w zamowieniu (przypisujemy obiekt przekazany htttpostem)
            string fullName = model.Firstname + " " + model.Lastname; //ustawienie stringa z polaczenia imienia i nazwiska 
            TempData["fullName"] = fullName; //ustawiamy wartosc tempdaty na imie i nazwisko
            return View(model: fullName); //zwracamy widok wyboru finansowania i przekazujemy tam imie i nazwisko
        }
        [HttpGet]
        public IActionResult ShowSummary(string klient, string finansowanie) //akcja po wyborze finansowania
        {
            CarOrder.reCalculate(); //mamy wszystkie dane zamowienia wiec je przeliczamy
            TempData["clientType"] = klient; //ustawiamy dwie tempdaty na rodzaj klienta oraz rodzaj finansowania
            TempData["payment"] = finansowanie;
            return View(); //zwracamy widok podsumowania zamowienia
        }

        [HttpGet]
        public IActionResult FinalDecission(string decission) //akcja po wyborze potwierdzenia zamowienia
        {
            return View(model:decission); //zwracamy widok przekazujac do niego decyzje 
        }

  
        public IActionResult Index() //akcja po przejsciu na strone glowna/po zaladowaniu strony glownej
        {
            CarOrder.Price = 0; //wyzerowanie ceny zamowienia (potrzebne przy ponownej konfiguracji)
            CarOrder.Extras = new List<Extra>(); //wyzerowanie listy dodatkow
            return View("Index",baseCars); //zwrocenie widoku strony glownej z przekazana lista pojazdow do wyboru
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
