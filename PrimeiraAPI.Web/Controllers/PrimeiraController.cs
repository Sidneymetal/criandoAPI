using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class PrimeiraController : ControllerBase
{
    [HttpGet]
    public string PrimeiraAPI(){
        return "Teste";
    }
    [HttpGet("apiDois")]
    public string SegundaAPI()
    {
        return "Teste Dois";
    }
    [HttpGet("outraAPI")]
    public IActionResult OutraAPI(int entrada)
    {   
        if(entrada == 1){
            return BadRequest("1 não é uma entrada válida.");
        }
        return Ok(""+entrada);
    }

}
