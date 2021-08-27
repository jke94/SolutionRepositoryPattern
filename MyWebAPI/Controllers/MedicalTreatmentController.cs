namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;

    [ApiController]
    [Route("[controller]")]
    public class MedicalTreatmentController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public MedicalTreatmentController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
