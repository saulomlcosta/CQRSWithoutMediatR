using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;

namespace Students.Queries;

public class GetStudentByIdQuery
{
    public Student? Handle(Guid id)
    {
        return InMemoryStudentRepository.Students.TryGetValue(id, out var student) ? student : default;
    }
}