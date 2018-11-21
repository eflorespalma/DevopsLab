using Microsoft.eShopWeb.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Microsoft.eShopWeb.Web.Controllers
{
    [Route("")]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly ILogger _logger;
        public CatalogController(ICatalogService catalogService, ILogger logger)
        {
            _catalogService = catalogService;
            _logger = logger;
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Index(int? brandFilterApplied, int? typesFilterApplied, int? page)
        {
            System.Diagnostics.Trace.TraceWarning("Slow response - database01");
            _logger.LogInformation("Se inicia Trace de Obtención de Datos");
            var itemsPage = 10;
            _logger.LogInformation($"Valor de Parametro {itemsPage}");
            var catalogModel = await _catalogService.GetCatalogItems(page ?? 0, itemsPage, brandFilterApplied, typesFilterApplied);
            return View(catalogModel);
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
