using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;

namespace Students.Commands;

public class UpdateStudentCommand
{
    public void Handle(Student student)
    {
        if (!InMemoryStudentRepository.Students.TryGetValue(student.Id, out var existingStudent))
        {
            return;
        }

        existingStudent.Name = student.Name;
        existingStudent.Email = student.Email;
    }
}