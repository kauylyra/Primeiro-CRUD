using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Application;
using Application.Models;

namespace BancoRafa.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteAplication clienteAplication = new ClienteAplication();
        // GET: Clientes
        [HttpGet]
        [Route("listar-Clientes")]
        public async Task<ActionResult> Index()
        {
            var clientesViewModel = await clienteAplication.ObterTodos();
            return View(clientesViewModel);
        }

        // GET: Clientes/Details/5
        [HttpGet]
        [Route("cliente-detalhe/{id:int}")]
        public async Task<ActionResult> Details(int? id)
        {
            var clienteViewModel = await clienteAplication.ObterPorId((int)id);

            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }
        // GET: Clientes/Create
        [HttpGet]
        [Route("novo-cliente")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-cliente")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id_Cliente,Nome,Data_Nascimento,Salario,Sexo,Estado,Ativo")] ClienteViewModel clienteViewModel)
        {
            TempData["Mensagem"] = "";
            try
            {
                if (ModelState.IsValid)
                {
                    await clienteAplication.CriarCliente(clienteViewModel);
                    TempData["Mensagem"] = "Cliente cadastrado com Sucesso !";
                    return RedirectToAction("Index");
                }
                return View(clienteViewModel);
            }
            catch(Exception excessao)
            {
                ViewBag.Mensagem = excessao.Message;
                TempData["Mensagem"] = excessao.Message;
                return View(clienteViewModel);
            }
        }

        [HttpGet]
        [Route("editar-cliente/{id:int}")]
        public async Task<ActionResult> Edit(int? id)
        {
            var clienteViewModel = await clienteAplication.ObterPorId((int)id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mensagem = "Não esqueça que esta ação é irreversível.";
            return View(clienteViewModel);
        }

        [HttpPost]
        [Route("editar-cliente/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id_Cliente,Nome,Data_Nascimento,Salario,Sexo,Estado,Ativo")] ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                await clienteAplication.EditarCliente(clienteViewModel);
                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }

        [HttpGet]
        [Route("excluir-cliente/{id:int}")]
        public async Task<ActionResult> Delete(int? id)
        {
            var cliente = await clienteAplication.ObterPorId((int)id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [Route("excluir-cliente/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await clienteAplication.ExcluirCliente(id);
            TempData["Mensagem1"] = "Cliente Excluido com Sucesso !";
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                clienteAplication.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
