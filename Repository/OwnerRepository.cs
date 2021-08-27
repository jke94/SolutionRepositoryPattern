namespace Repository
{
    using Entities;
    using Entities.Models;
    using Repository.Interfaces;

    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}