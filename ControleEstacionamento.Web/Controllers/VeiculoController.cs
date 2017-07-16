using ControleEstacionamento.Persistence.Entity.Context;
using ControleEstacionamento.Repository.Respositories;
using ControleEstacionamento.Repository.Respositories.Interfaces;
using System.Web.Mvc;

namespace ControleEstacionamento.Web.Controllers
{
    public class VeiculoController : Controller
    {
        private IVeiculoRepository _veiculoRepository = new VeiculoRepository(new EstacionamentoDbContext());
        private IValoresRepository _valoresRepository = new ValoresRepository(new EstacionamentoDbContext());
        // GET: Veiculo
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}