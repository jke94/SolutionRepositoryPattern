namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;

    [ApiController]
    [Route("[controller]")]
    public class PatientController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public PatientController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
