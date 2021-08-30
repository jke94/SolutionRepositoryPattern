namespace MyWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class DoctorController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public DoctorController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<DoctorDTO> Get()
        {
            //var doctors = _repoWrapper.Doctor.FindByCondition(x => x.Name.Equals("Murphy"));
            var doctors = _repoWrapper.Doctor.FindAll();

            IList<DoctorDTO> doctorList = new List<DoctorDTO>();

            foreach (var item in doctors)
            {
                doctorList.Add(new DoctorDTO()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    DateBorn = item.DateBorn.ToString("MM-dd-yyyy")

                });
            }

            return doctorList;
        }

        [HttpGet("GetDoctorsByName/{name}")]
        public IEnumerable<DoctorDTO> GetDoctorsByName(string name)
        {
            var doctors = _repoWrapper.Doctor.FindByCondition(x => x.Name.Equals(name));

            IList<DoctorDTO> doctorList = new List<DoctorDTO>();

            foreach (var item in doctors)
            {
                doctorList.Add(new DoctorDTO()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    DateBorn = item.DateBorn.ToString("MM-dd-yyyy")

                });
            }

            return doctorList;
        }

        [HttpGet("GetDoctorsBySurname/{surname}")]
        public IEnumerable<DoctorDTO> GetDoctorsBySurname(string surname)
        {
            var doctors = _repoWrapper.Doctor.FindByCondition(x => x.Surname.Equals(surname));

            IList<DoctorDTO> doctorList = new List<DoctorDTO>();

            foreach (var item in doctors)
            {
                doctorList.Add(new DoctorDTO()
                {
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    DateBorn = item.DateBorn.ToString("MM-dd-yyyy")

                });
            }

            return doctorList;
        }
    }

    public class DoctorDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateBorn { get; set; }
        public int Age { get; set; }
    }
}
