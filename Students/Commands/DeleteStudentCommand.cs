using CQRSWithoutMediatR.Repositories;

namespace Students.Commands;

public class DeleteStudentCommand
{
    public void Handle(Guid id)
    {
        InMemoryStudentRepository.Students.Remove(id);
    }
}