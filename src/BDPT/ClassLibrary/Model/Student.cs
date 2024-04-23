
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
}
