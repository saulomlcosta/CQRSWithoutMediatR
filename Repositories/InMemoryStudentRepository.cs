using CQRSWithoutMediatR.Entities;

namespace CQRSWithoutMediatR.Repositories
{
    public class InMemoryStudentRepository
    {
        private static readonly Dictionary<Guid, Student> Students = new();

        public List<Student> Get()
        {
            return Students.Values.ToList();
        }
        public Student? GetById(Guid id)
        {
            return Students.TryGetValue(id, out var student) ? student : default;
        }

        public void Add(Student student)
        {
            Students.Add(student.Id, student);
        }

        public void Update(Student student)
        {
            if (!Students.TryGetValue(student.Id, out var existingStudent))
            {
                return;
            }

            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
        }

        public void Delete(Guid id)
        {
            Students.Remove(id);
        }
    }
}