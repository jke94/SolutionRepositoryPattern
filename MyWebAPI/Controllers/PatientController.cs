namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]
    public class PatientController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public PatientController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<PatientDTO> Get()
        {
            var patients = _repoWrapper.Patient.FindAll();

            IList<PatientDTO> patientDTOs = new List<PatientDTO>();

            foreach (var item in patients)
            {
                patientDTOs.Add(new PatientDTO()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age
                });
            }

            return patientDTOs;
        }

        [HttpGet("GetPatientsAndMedicalTreatment")]
        public IEnumerable<PatientMedicaltreatmenDTO> GetPatientsAndMedicalTreatment(string name)
        {
            var _medicalTreatments = _repoWrapper.MedicalTreatment.FindAll();
            var _patients = _repoWrapper.Patient.FindByCondition(element => element.Name.Equals(name));

            IList<PatientMedicaltreatmenDTO> patientMedicaltreatmenDTOs = new List<PatientMedicaltreatmenDTO>();

            foreach (var item in _patients)
            {
                patientMedicaltreatmenDTOs.Add(new PatientMedicaltreatmenDTO()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    MedicalTreatmentDTOs = ((Func<IList<MedicalTreatmentDTO>>)(() => {

                        var medicalTreatmentDTOs = new List<MedicalTreatmentDTO>();

                        foreach (var i in _medicalTreatments.Where(element => element.PatientId.Equals(item.PatientId)))
                        {
                            medicalTreatmentDTOs.Add(new MedicalTreatmentDTO() { Medicine = i.Medicine, Days = i.Days});
                        }

                        return medicalTreatmentDTOs; 
                    }))()
                });
            };
            
            return patientMedicaltreatmenDTOs;
        }
    }

    public class PatientMedicaltreatmenDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public IList<MedicalTreatmentDTO> MedicalTreatmentDTOs { get; set; }
    }
}
