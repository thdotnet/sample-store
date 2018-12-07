using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Core.Interfaces;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public HomeController(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var numeroProdutos = 10;

            var produtos = _produtoService.ObterProdutos(numeroProdutos);
            var vm = _mapper.Map<List<ProdutoListaViewModel>>(produtos);

            return View(vm);
        }

        
    }
}
