namespace MyWebAPI.Controllers
{
    using Contracts;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]

    public class AcountsController : Controller
    {
        private IRepositoryWrapper _repoWrapper;


        public AcountsController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repoWrapper.Owner.FindAll();

            return new string[] { "value1", "value2" };
        }
    }
}
