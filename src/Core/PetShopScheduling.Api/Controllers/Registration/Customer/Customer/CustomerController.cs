using Microsoft.AspNetCore.Mvc;
using PetShopScheduling.Argument.Argument.Registration;

namespace PetShopScheduling.Api.Controllers.Registration;

[Route("Api/[controller]")]
public class CustomerController : Controller
{
    [HttpPost("Create")]
    public ActionResult CreateCustomer([FromBody] InputCreateCustomer inputCreateCustomer)
    {
        return Ok("console.log('passou aqui')");
    }
}