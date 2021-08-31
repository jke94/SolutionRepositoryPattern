namespace Repository.RepositoryEntities
{
    using Entities.Context;
    using Entities.Models;
    using Repository.Interfaces;

    public class MedicalTreatmentRepository : RepositoryBase<MedicalTreatment>, IMedicalTreatmentRepository
    {
        public MedicalTreatmentRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
