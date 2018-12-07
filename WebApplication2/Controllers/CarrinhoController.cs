using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Core.Interfaces;
using WebApplication2.Core.Models;
using WebApplication2.Core.Services;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class CarrinhoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoController(IProdutoService produtoService, ICarrinhoService carrinhoService)
        {
            _produtoService = produtoService;
            _carrinhoService = carrinhoService;
        }

        public IActionResult Add(int produtoId)
        {
            var usuario = HttpContext.User.Identity.Name;

            Carrinho carrinho = _carrinhoService.Obter(usuario);

            carrinho.Adicionar(_produtoService.ObterProduto(produtoId));

            _carrinhoService.SalvarCarrinho(usuario, carrinho);

            return PartialView("Lista", carrinho);
        }

        public IActionResult Finalizar()
        {
            var usuario = HttpContext.User.Identity.Name;
            var carrinho = _carrinhoService.Obter(usuario);

            _carrinhoService.Limpar(usuario);

            return View(carrinho);
        }
    }
}