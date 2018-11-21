using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopWeb.Web.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Controllers
{
    [Route("")]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Index(int? brandFilterApplied, int? typesFilterApplied, int? page)
        {
            var client = new TelemetryClient();
            client.TrackTrace($"CatalogController:::::{page}", ApplicationInsights.DataContracts.SeverityLevel.Information);
            var itemsPage = 10;
            client.TrackTrace($"Items a filtrar:::::::{itemsPage}", ApplicationInsights.DataContracts.SeverityLevel.Information);
            var catalogModel = await _catalogService.GetCatalogItems(page ?? 0, itemsPage, brandFilterApplied, typesFilterApplied);
            client.TrackTrace($"Cantidad final Obtenida:::::::{catalogModel.Brands.Count()}");
            return View(catalogModel);
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
