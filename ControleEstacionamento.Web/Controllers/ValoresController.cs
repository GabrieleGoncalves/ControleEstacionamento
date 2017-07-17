using ControleEstacionamento.Persistence.Entity.Context;
using ControleEstacionamento.Repository.Respositories;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using System.Web.Mvc;
using ControleEstacionamento.Web.ViewModels.Valores;


namespace ControleEstacionamento.Web.Controllers
{
    public class ValoresController : Controller
    {
        private IMovimentacaoVeiculoRepository _movimentacaoVeiculoRepository = new MovimentacaoVeiculoRepository(new EstacionamentoDbContext());
        private IValoresRepository _valoresRepository = new ValoresRepository(new EstacionamentoDbContext());
        // GET: Veiculo
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar([Bind ( Include = "id, InicioVigencia, FimVigencia, ValorHora, ValorHoraAdicionl")] ValoresViewModelList valores)
        {
            //if (ModelState.IsValid)
            //{
            //    _valoresRepository.Insert(valores);
            //    _valoresRepository

            //}
            return View();
        }
    }
}