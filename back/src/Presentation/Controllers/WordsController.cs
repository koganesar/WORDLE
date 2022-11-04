using Application;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("")]
public class WordsController : ControllerBase
{
    private readonly IWordsService _wordsService;

    public WordsController(IWordsService wordsService) =>
        _wordsService = wordsService;

    [HttpGet]
    public async Task<IActionResult> Index() =>
        new JsonResult(await _wordsService.GetWordsAsync());
}
