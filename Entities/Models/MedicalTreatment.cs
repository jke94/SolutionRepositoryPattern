namespace Entities.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MedicalTreatment
    {
        [Key]
        public int MedicalTreatmentId { get; set; }
        public string Medicine { get; set; }
        public int Days { get; set; }


        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}