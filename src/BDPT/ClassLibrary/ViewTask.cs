namespace ClassLibrary
{
    public class Student
    {
        /// <summary>
        /// Vorname des Studenten
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Nachname des Studenten
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        ///     Name des Studenten.
        /// </summary>
        public string Name => $"{FirstName} {LastName}";
        /// <summary>
        /// Alter des Studenten
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Matrikelnummer des Studenten
        /// </summary>
        public string StudentIdentificationNumber { get; set; } = string.Empty;
    }

    public static class StudentDataSet
    {
        public static IEnumerable<Student> Students = GetStudents();

        private static IEnumerable<Student> GetStudents()
        {
            var random = new Random();
            for (int i = 0; i < 500; i++)
            {
                yield return new Student()
                {
                    FirstName = "Max",
                    LastName = $"Mustermann{i}",
                    Age = i % 25 + 18,
                    StudentIdentificationNumber = $"{i}{i}{i}"
                };
            }
        }
    }
}
