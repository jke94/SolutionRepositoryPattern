namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]
    public class MedicalTreatmentController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public MedicalTreatmentController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<MedicalTreatmentDTO> Get()
        {
            var medicaltreatments = _repoWrapper.MedicalTreatment.FindAll();

            IList<MedicalTreatmentDTO> mediacaltreatmenList = new List<MedicalTreatmentDTO>();

            foreach (var item in medicaltreatments)
            {
                mediacaltreatmenList.Add(new MedicalTreatmentDTO()
                {
                    Medicine = item.Medicine,
                    Days = item.Days
                });
            }

            return mediacaltreatmenList;
        }

        [HttpGet("GetMedicalTreatmentsAndPatient")]
        public IEnumerable<MedicalTreatmentDTO> GetMedTreatmentsAndPatient()
        {
            var _medicalTreatments = _repoWrapper.MedicalTreatment.FindAll();
            var _patients = _repoWrapper.Patient.FindAll();

            IList<MedicalTreatmentDTO> medicalTreatmentDTOs = new List<MedicalTreatmentDTO>();

            foreach(var item in _medicalTreatments)
            {
                medicalTreatmentDTOs.Add(new MedicalTreatmentDTO()
                {
                    Medicine = item.Medicine,
                    Days = item.Days,
                    Patient = new PatientDTO()
                    {
                        Age = _patients.FirstOrDefault(element => element.PatientId.Equals(item.PatientId)).Age,
                        Name = _patients.FirstOrDefault(element => element.PatientId.Equals(item.PatientId)).Name,
                        Surname = _patients.FirstOrDefault(element => element.PatientId.Equals(item.PatientId)).Surname
                    }
                });
            }

            return medicalTreatmentDTOs;
        }

        [HttpGet("GetMedicalTreatments/{medicine}")]
        public IEnumerable<MedicalTreatmentDTO> GetDoctorsByName(string medicine)
        {
            var _medicalTreatments = _repoWrapper.MedicalTreatment.FindByCondition(x => x.Medicine.Equals(medicine));

            IList<MedicalTreatmentDTO> medicalTreatmentDTOs = new List<MedicalTreatmentDTO>();

            foreach (var item in _medicalTreatments)
            {
                medicalTreatmentDTOs.Add(new MedicalTreatmentDTO()
                {
                    Medicine = item.Medicine,
                    Days = item.Days,
                });
            }

            return medicalTreatmentDTOs;
        }
    }

    public class MedicalTreatmentDTO
    {
        public string Medicine { get; set; }
        public int Days { get; set; }
        public PatientDTO Patient { get; set; }
    }

    public class PatientDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
