namespace Repository
{
    using Entities;
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
