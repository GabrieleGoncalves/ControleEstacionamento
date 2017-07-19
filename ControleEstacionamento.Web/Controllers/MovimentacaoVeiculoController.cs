using System.Collections.Generic;
using ControleEstacionamento.Persistence.Entity.Context;
using ControleEstacionamento.Repository.Respositories;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using System.Web.Mvc;
using ControleEstacionamento.Web.ViewModels.MovimentacaoVeiculo;
using ControleEstacionamento.Domain.Entities;
using AutoMapper;
using ControleEstacionamento.Web.ViewModels.Valores;
using System.Linq;

namespace ControleEstacionamento.Web.Controllers
{
    public class MovimentacaoVeiculoController : Controller
    {
        private IMovimentacaoVeiculoRepository _movimentacaoVeiculoRepository = new MovimentacaoVeiculoRepository(new EstacionamentoDbContext());
        private IValoresRepository _valoresRepository = new ValoresRepository(new EstacionamentoDbContext());

        // vou digitar o dia de entrada do veiculo para poder a tabela de precos
        // buscar pela placa

        // GET: MovimentacaoVeiculo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IndexMovimentacaoVeiculo(int? id)
        {
            List<MovimentacaoVeiculo> veiculo = _movimentacaoVeiculoRepository.Select();
            List<MovimentacaoVeiculoViewModelList> viewModel = Mapper.Map<List<MovimentacaoVeiculo>, List<MovimentacaoVeiculoViewModelList>>(veiculo); 

            return View();
        }
        //marcar a data e hora de entrada do veículo
        [HttpGet]
        public ActionResult EntradaVeiculo()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EntradaVeiculo(MovimentacaoVeiculoViewModelList viewModel)
        {

            if (!ModelState.IsValid)
                return View(viewModel);
            
            
            MovimentacaoVeiculo veiculo = Mapper.Map<MovimentacaoVeiculoViewModelList, MovimentacaoVeiculo>(viewModel);
            Valores valores = _valoresRepository.Select(p => p.InicioVigencia <= veiculo.Entrada).FirstOrDefault();
            veiculo.ValorId = valores.ValorId;
            _movimentacaoVeiculoRepository.Insert(veiculo); 
            return View("Index");
            
        }

        [HttpGet]
        public ActionResult Saida(int? id)
        {
            MovimentacaoVeiculo veiculo = _movimentacaoVeiculoRepository.SelectById(id.Value);
            _movimentacaoVeiculoRepository.Update(veiculo);
            return View();

        }

        [HttpPost]
        public ActionResult Saida(MovimentacaoVeiculoViewModelList viewModel)
        {

            if (!ModelState.IsValid)
                return View(viewModel);


            MovimentacaoVeiculo veiculo = Mapper.Map<MovimentacaoVeiculoViewModelList, MovimentacaoVeiculo>(viewModel);
            //Valores valores = _valoresRepository.Select(p => p.InicioVigencia <= veiculo.Entrada).FirstOrDefault();
            //veiculo.ValorId = valores.ValorId;
            _movimentacaoVeiculoRepository.Update(veiculo);
            return View("Index");

            
        }


        }
}