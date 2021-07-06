using App2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App2.Data;

namespace App2.Controllers
{
    public class HomeController : Controller
    {
        public BancoDeDados BancoDeDados { get; }

        public HomeController(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        public IActionResult Index()
        {
            var model = new HomeModel();

            //model.QtdAmigos = BancoDeDados.Amigos.Count();

            var amigos = BancoDeDados.Amigos.ToList();
            var listaOrdenadaAmigos = amigos.OrderByDescending(amigo => amigo.Aniversario).ToList();


            return View(listaOrdenadaAmigos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
