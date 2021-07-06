using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App2.Models;
using App2.Data;

namespace App2.Controllers
{
    public class AmigosController : Controller
    {
        public AmigosController(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        private BancoDeDados BancoDeDados { get; set; }

        [HttpGet]
        public IActionResult Index(string nome)
        {
            List<Amigo> amigos;

            if (string.IsNullOrWhiteSpace(nome))
            {
                amigos = BancoDeDados.Amigos.ToList();
                return View(amigos);
            }

            //var listaOrdenadaAmigos = amigos.OrderBy(amigo => amigo.Aniversario).ToList();

            amigos = BancoDeDados.Amigos.Where(amigo => amigo.Nome.Contains(nome)).ToList();

            return View(amigos);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Cadastro(string nome, string email, DateTime aniversario)
        {
            var amigo = new Amigo();
            amigo.Nome = nome;
            amigo.Email = email;
            amigo.Aniversario = aniversario;

            BancoDeDados.Amigos.Add(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("/amigos/index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            return View(amigo);
        }

        [HttpPost]
        public IActionResult Editar(int id, string nome, string email, DateTime aniversario)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            amigo.Nome = nome;
            amigo.Email = email;
            amigo.Aniversario = aniversario;

            BancoDeDados.Amigos.Update(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("/amigos");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            return View(amigo);
        }

        [HttpPost]
        public IActionResult ExcluirAmigo(int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            BancoDeDados.Amigos.Remove(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("/amigos");
        }
    }
}
