using ClassLibrary.Model;

namespace ClassLibrary
{
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
                    Age = random.Next(22, 50),
                    StudentIdentificationNumber = random.Next(10000000, 100000000).ToString()
                };
            }
        }
    }
}
