namespace Repository
{
    using Contracts;
    using Entities;
    using Entities.Models;

    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}