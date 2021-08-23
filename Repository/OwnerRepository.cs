namespace Repository
{
    using Contracts;
    using Entities;
    using Entities.Models;

    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}