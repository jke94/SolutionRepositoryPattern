namespace Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IDoctorRepository Doctor { get; }
        IPatientRepository Patient { get; }
        IMedicalTreatmentRepository MedicalTreatment { get; }
        void Save();
    }
}