using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;

namespace Students.Commands;
public class AddStudentCommand
{
    public void Handle(Student student)
    {
        InMemoryStudentRepository.Students.Add(student.Id, student);
    }
}