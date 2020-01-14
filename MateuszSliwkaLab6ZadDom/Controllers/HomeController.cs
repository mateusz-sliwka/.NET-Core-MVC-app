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
       
        List<CarTypeModel> baseCars;
       
        public HomeController()
        {
 
            baseCars = new List<CarTypeModel>();
            baseCars.Add(new CarTypeModel("Sprinter", 3, "Bus idealny do transportu", 120000, "~/Images/sprinter.png", new List<string> { "2.0d", "3.0d" }));
            baseCars.Add(new CarTypeModel("Klasa S", 5, "Limuzyna dla wymagajacych", 250000, "~/Images/sklasa.png",new List<string>{ "S350i","S350d"}));
        }
      
      
        public IActionResult ChooseSpecification(string model)
        {
            CarOrder.Model = baseCars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault(); //przypisanie do zamowienia wybranego modelu auta
            ViewBag.Model = CarOrder.Model.Model; //zapisanie do viewbaga modelu ktory bedziemy wyswietlac w tytule
            return View(); //zwrocenie widoku
        }

        [HttpPost]
        public IActionResult ShowExtras(string choosenEngine, string choosenTransmission, string choosenDrive)
        {
            ViewBag.Model =CarOrder.Model.Model;

    
           CarOrder.Engine = new Extra(choosenEngine.Split('-')[0], Int32.Parse(choosenEngine.Split('-')[1]));
           CarOrder.Transmission = new Extra(choosenTransmission.Split('-')[0], Int32.Parse(choosenTransmission.Split('-')[1]));
            CarOrder.Drive = new Extra(choosenDrive.Split('-')[0], Int32.Parse(choosenDrive.Split('-')[1]));
      
            return View("ChooseExtras");
        }
        [HttpPost]
        public IActionResult ShowOwner(string[] extras)
        { 
            if(extras!=null)
            foreach (string argument in extras)
            {
                CarOrder.Extras.Add(new Extra(argument.Split('-')[0], Int32.Parse(argument.Split('-')[1])));
            }
            TempData["currentCar"] = CarOrder.Engine.Name;

            return View("ChooseOwner");
        }
        [HttpGet]
        public IActionResult ShowSummary(string klient, string finansowanie)
        {
            CarOrder.reCalculate();
            string x = Request.QueryString.Value;
            TempData["clientType"] = klient;
            TempData["payment"] = finansowanie;
            //return View(model:CarOrder);
            return View();
        }
        [HttpGet]
        public IActionResult FinalDecission(string decission)
        {
        
       
            return View(model:decission);
        }
        [HttpPost]
        public IActionResult ShowBilling(Client model)
        {
            CarOrder.Owner = model;
            string fullName = model.Firstname + " " + model.Lastname;
            TempData["fullName"] = fullName;
            return View(model:fullName);
        }
 
     

        public IActionResult Index()
        {
            CarOrder.Price = 0;
            CarOrder.Extras = new List<Extra>();
            return View("Index",baseCars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
