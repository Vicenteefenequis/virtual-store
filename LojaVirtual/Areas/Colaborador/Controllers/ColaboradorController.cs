﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ColaboradorController : Controller
    {

        private IColaboradorRepository _colaboradorRepository;

        public ColaboradorController(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }
        public IActionResult Index(int? pagina)
        {
           IPagedList<Models.Colaborador> colaboradores =  _colaboradorRepository.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborar)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            return View();
        }
        public IActionResult Atualizar([FromForm] Models.Colaborador colaborar,int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return View();
        }
    }
}
