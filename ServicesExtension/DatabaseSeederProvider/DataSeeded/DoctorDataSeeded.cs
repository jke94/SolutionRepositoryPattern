namespace ServicesExtension.DatabaseSeederProvider.DataSeeded
{
    using Entities.Models;
    using System;

    public static class DoctorDataSeeded
    {
        public static string [] names =
        {
            "Jack",     "Jasper",   "Kevin",        "Matthew",      "Maverick",     "Nathaniel",
            "Jade",     "Kaylee",   "Kylie",        "Lucy",         "Melanie",      "Naomi",
            "Phoebe",   "Poppy",    "Primerose",    "Jane",         "James",        "John",
            "Joseph",   "Mary",     "Robert",       "Sarah",        "Joey",         "Justin"
        };

        public static string [] surname =
        {
            "Smith",        "Jones",        "Murphy",   "Smith",    "O'Kelly",      "Johnson",
            "Williams",     "O'Sullivan",   "Brown",    "Walsh",    "Taylor",       "Davies",
            "O'Brien",      "Miller",       "Wilson",   "Byrne",    "Davis",        "Evans",
            "O'Ryan",       "Garcia",       "Thomas",   "O'Connor", "Rodriguez",    "O'Neill"
        };

        /// <summary>
        ///     Generate randon names to seed in database.
        /// </summary>
        /// <returns>An array of random doctors.</returns>
        public static Doctor[] GenerateRandomDoctors()
        {
            Doctor[] arrayDoctors = new Doctor[SharedVariables.NumberOfDoctors];

            Random random = new Random();
            int range = (65 * 365); // 65 years

            for (int i = 0; i < arrayDoctors.Length; i++)
            {
                var auxDateBorn = DateTime.Today.AddDays(-(random.Next(range) + (18 * 365)));
                arrayDoctors[i] = new Doctor()
                {
                    DoctorID = i + 1,
                    Name = names[random.Next(0, names.Length)],
                    Surname = surname[random.Next(0, surname.Length)],
                    DateBorn = auxDateBorn,
                    Age = DateTime.Today.Year - auxDateBorn.Year
                };
            }

            return arrayDoctors;
        }
    }
}
