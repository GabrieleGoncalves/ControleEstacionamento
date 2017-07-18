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

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
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
        public ActionResult Cadastrar(ValoresViewModelList viewModel)
        {
            Valores valores = Mapper.Map<ValoresViewModelList, Valores>(viewModel);
            _valoresRepository.Insert(valores);
            return View();
        }
    }
}