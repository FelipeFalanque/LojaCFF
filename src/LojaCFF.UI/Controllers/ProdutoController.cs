﻿using LojaCFF.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaCFF.UI.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var produtos = new List<Produto>() {
                new Produto() { Id= 1, Nome = "Picanha", Preco = 70.5M, Qtde= 150, Tipo = "Alimento"},
                new Produto() { Id= 2, Nome = "Pasta de dente", Preco = 9.5M, Qtde= 250, Tipo = "Higiene"},
                new Produto() { Id= 3, Nome = "Desinfetante", Preco = 8.99M, Qtde= 520, Tipo = "Limpeza"},
            };


            return View(produtos);
        }
    }
}