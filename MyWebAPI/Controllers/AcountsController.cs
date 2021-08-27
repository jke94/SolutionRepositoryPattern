namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

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
        public IEnumerable<Entities.Models.Account> Get()
        {
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repoWrapper.Owner.FindAll();

            var accounts = _repoWrapper.Account.FindAll();
            
            IList<Entities.Models.Account> listAccounts = new List<Entities.Models.Account>();

            foreach(var item in accounts)
            {
                listAccounts.Add( new Entities.Models.Account() 
                    { 
                        AccountId = item.AccountId,
                        AccountType = item.AccountType,
                        DateCreated = item.DateCreated,
                        Owner = item.Owner,
                        OwnerId = item.OwnerId
                    }
                );
            }

            return listAccounts;
        }
    }
}
