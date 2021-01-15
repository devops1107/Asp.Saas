using Microsoft.AspNetCore.Mvc;

namespace Asp.Saas.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Controller
    {
    }
}
