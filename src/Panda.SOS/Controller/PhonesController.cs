using Microsoft.AspNetCore.Mvc;
namespace Panda.SOS.Controller;

[ApiController]
[Route("[controller]")]
public class PhonesController : ControllerBase
{
    private readonly ISearchProvider<MobileCompanieIndex> _search;

    public PhonesController(ISearchProvider<MobileCompanieIndex> search)
    {
        _search = search;
    }

    [HttpGet("Search")]
    public async Task<IActionResult> Get([FromQuery] string? search) => Ok(await _search.SearchAsync(search));
}
