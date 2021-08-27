namespace Repository
{
    using Entities;
    using Entities.Models;
    using Repository.Interfaces;

    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}