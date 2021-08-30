namespace Repository.RepositoryEntities
{
    using Entities.Context;
    using Entities.Models;
    using Repository.Interfaces;

    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
