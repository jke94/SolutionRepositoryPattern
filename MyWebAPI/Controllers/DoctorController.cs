namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;

    [ApiController]
    [Route("[controller]")]
    public class DoctorController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public DoctorController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
