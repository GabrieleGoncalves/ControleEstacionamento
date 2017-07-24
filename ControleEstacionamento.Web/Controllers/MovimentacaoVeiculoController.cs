using System.Collections.Generic;
using ControleEstacionamento.Persistence.Entity.Context;
using ControleEstacionamento.Repository.Respositories;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using System.Web.Mvc;
using ControleEstacionamento.Web.ViewModels.MovimentacaoVeiculo;
using ControleEstacionamento.Domain.Entities;
using AutoMapper;
using System.Linq;
using System;

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
            List<MovimentacaoVeiculoViewModelList> viewModel = Mapper.Map<List< MovimentacaoVeiculoViewModelList>>
                ( _movimentacaoVeiculoRepository.Select());
            return View(viewModel);
        }
        
        //marcar a data e hora de entrada do veículo
        [HttpGet]
        public ActionResult EntradaVeiculo()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EntradaVeiculo(MovimentacaoVeiculoViewModelEntrada viewModel)
        {

            if (!ModelState.IsValid)
                return View(viewModel);

            MovimentacaoVeiculo veiculo = Mapper.Map<MovimentacaoVeiculo>(viewModel);

            veiculo.Entrada = DateTime.Now;
            
            Valores valores = _valoresRepository.Select(p => p.InicioVigencia <= veiculo.Entrada).FirstOrDefault();
            veiculo.ValorId = valores.ValorId;
            _movimentacaoVeiculoRepository.Insert(veiculo);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Saida(int? id)
        {
            MovimentacaoVeiculoViewModelList veiculoViewModel = Mapper.Map<MovimentacaoVeiculoViewModelList>(_movimentacaoVeiculoRepository.SelectById(id.Value));
            return View(veiculoViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Saida(MovimentacaoVeiculoViewModelList viewModel)
        {

            if (!ModelState.IsValid || viewModel.Entrada > viewModel.Saida)
                return View(viewModel);

         
            MovimentacaoVeiculo veiculo = _movimentacaoVeiculoRepository.SelectById(viewModel.MovimentacaoVeiculoId);
            veiculo.Saida = viewModel.Saida.Value;
            TimeSpan diferenca = veiculo.Saida.Value - veiculo.Entrada;
            veiculo.MinutosPermanencia = Convert.ToInt32(diferenca.TotalMinutes) % 60;
            veiculo.HorasPermanencia = Convert.ToInt32(diferenca.TotalHours);

            if(veiculo.MinutosPermanencia > 10)
            {
                if (veiculo.MinutosPermanencia <= 30)
                {
                    veiculo.ValorTotal = veiculo.Valor.ValorHora + (veiculo.Valor.ValorAdicional * (veiculo.HorasPermanencia.Value - 1)) + (veiculo.Valor.ValorAdicional / 2);
                }else
                    veiculo.ValorTotal = veiculo.Valor.ValorHora + (veiculo.Valor.ValorAdicional * (veiculo.HorasPermanencia.Value - 1)) + (veiculo.Valor.ValorAdicional);
                
            }else
                veiculo.ValorTotal = veiculo.Valor.ValorHora + (veiculo.Valor.ValorAdicional * (veiculo.HorasPermanencia.Value - 1));


            _movimentacaoVeiculoRepository.Update(veiculo);
            return RedirectToAction("Index");

        }


    }
}