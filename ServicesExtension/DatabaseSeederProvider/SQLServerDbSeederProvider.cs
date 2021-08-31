namespace ServicesExtension.DatabaseSeederProvider
{
    using Microsoft.Extensions.DependencyInjection;
    using Repository.Interfaces;
    using ServicesExtension.DatabaseSeederProvider.DataSeeded;

    public static class SQLServerDbSeederProvider
    {
        public static void AddDataInRepositoryWrapper(this IServiceCollection services)
        {
            var theService = services.BuildServiceProvider().GetService<IRepositoryWrapper>();

            theService.Doctor.Create(DoctorDataSeeded.GenerateRandomDoctors());
            theService.Patient.Create(PatientDataSeeded.GenerateRandomPatients());
            theService.MedicalTreatment.Create(MedicalTreatmentDataSeeded.GenerateMedicalTreatment());

            theService.Save();
        }
    }
}