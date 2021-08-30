namespace ServicesExtension.DatabaseSeederProvider.DataSeeded
{
    using Entities.Models;
    using ServicesExtension.DatabaseSeederProvider;
    using System;

    public static class MedicalTreatmentDataSeeded
    {
        public static string[] medicineNames =
        {
            "Paracetamol",     "Aspirina",      "Ibuprofeno",       "Morfine",      "Azodermol",
            "Omeprazonl",      "Ramipril",      "Amoxicilina",      "Glucagón",     "Idarubicin",
            "Ketoconazol",     "Letrozol",      "Levobunolol",      "Levorfanol",   "Dupixent",
            "Elocon",          "Flomax",        "Ketek",            "relpax",       "Sancuso"
        };

        internal static MedicalTreatment[] GenerateMedicalTreatment()
        {
            MedicalTreatment[] arrayPatient = new MedicalTreatment[SharedVariables.NumberOfMedicalTreatments];


            Random random = new Random();

            for (int i = 0; i < arrayPatient.Length; i++)
            {
                arrayPatient[i] = new MedicalTreatment()
                {
                    MedicalTreatmentId = i + 1,
                    Medicine = medicineNames[random.Next(0, medicineNames.Length)],
                    Days = random.Next(10, 30),
                    PatientId = random.Next(1, SharedVariables.NumberOfPatients)
                };
            }

            //arrayPatient = new MedicalTreatment[]
            //{
            //    new MedicalTreatment()
            //    {
            //        Medicine = "Paracetamol",
            //        Days = 8,
                    
            //    }
            //}


            return arrayPatient;
        }
    }
}
