using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Core.Interfaces;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public IActionResult Index(int id)
        {
            var produto = _produtoService.ObterProduto(id);
            var vm = _mapper.Map<ProdutoListaViewModel>(produto);

            return View(vm);
        }
    }
}