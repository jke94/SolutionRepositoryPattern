namespace Repository
{
    using Entities.Context;
    using Repository.Interfaces;
    using Repository.RepositoryEntities;

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IDoctorRepository _doctor;
        private IPatientRepository _patient;
        private IMedicalTreatmentRepository _medicalTreatment;

        public IPatientRepository Patient
        {
            get
            {
                if (_patient == null)
                {
                    _patient = new PatientRepository(_repoContext);
                }

                return _patient;
            }
        }

        public IDoctorRepository Doctor
        {
            get
            {
                if (_doctor == null)
                {
                    _doctor = new DoctorRepository(_repoContext);
                }

                return _doctor;
            }
        }

        public IMedicalTreatmentRepository MedicalTreatment
        {
            get
            {
                if (_medicalTreatment == null)
                {
                    _medicalTreatment = new MedicalTreatmentRepository(_repoContext);
                }

                return _medicalTreatment;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}