using Microsoft.eShopWeb.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Microsoft.eShopWeb.Web.Controllers.Api
{
    public class CatalogController : BaseApiController
    {
        private readonly ICatalogService _catalogService;
        private readonly ILogger _logger;

        public CatalogController(ICatalogService catalogService, ILogger logger)
        {
            _catalogService = catalogService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> List(int? brandFilterApplied, int? typesFilterApplied, int? page)
        {
            _logger.LogInformation("Se inicia Trace de Obtención de Datos");
            var itemsPage = 10;
            _logger.LogInformation($"Valor de Parametro {itemsPage}");
            var catalogModel = await _catalogService.GetCatalogItems(page ?? 0, itemsPage, brandFilterApplied, typesFilterApplied);
            return Ok(catalogModel);
        }
    }
}
