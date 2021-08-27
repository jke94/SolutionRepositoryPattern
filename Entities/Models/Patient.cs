namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateBorn { get; set; }
        public int Age { get; set; }
        public ICollection<MedicalTreatment> Patients { get; set; }


        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}