namespace Repository.RepositoryEntities
{
    using Entities.Context;
    using Entities.Models;
    using Repository.Interfaces;

    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
