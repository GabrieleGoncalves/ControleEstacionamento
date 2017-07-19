using System.Collections.Generic;
using ControleEstacionamento.Persistence.Entity.Context;
using ControleEstacionamento.Repository.Respositories;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using System.Web.Mvc;
using ControleEstacionamento.Web.ViewModels.Valores;
using ControleEstacionamento.Domain.Entities;
using AutoMapper;

namespace ControleEstacionamento.Web.Controllers
{
    public class ValoresController : Controller
    {
        private IMovimentacaoVeiculoRepository _movimentacaoVeiculoRepository = new MovimentacaoVeiculoRepository(new EstacionamentoDbContext());
        private IValoresRepository _valoresRepository = new ValoresRepository(new EstacionamentoDbContext());
        // GET: Valores

        [HttpGet]
        public ActionResult Index()
        {

            List<Valores> valores = _valoresRepository.Select();
            List<ValoresViewModelList> viewModel = Mapper.Map<List<Valores>, List<ValoresViewModelList>>(valores);
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(ValoresViewModelList viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            Valores valores = Mapper.Map<ValoresViewModelList, Valores>(viewModel);
            _valoresRepository.Insert(valores);
            return View("Index");
        }
    }
}