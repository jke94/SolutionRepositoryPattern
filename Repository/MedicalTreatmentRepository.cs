namespace Repository
{
    using Entities;
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
