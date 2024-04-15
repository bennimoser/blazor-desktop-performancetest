
namespace ClassLibrary.Model
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
        /// Semester des Studenten
        /// </summary>
        public int Semester { get; set; } = 1;

        /// <summary>
        /// Alter des Studenten
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Matrikelnummer des Studenten
        /// </summary>
        public string StudentIdentificationNumber { get; set; } = string.Empty;
    }
}
