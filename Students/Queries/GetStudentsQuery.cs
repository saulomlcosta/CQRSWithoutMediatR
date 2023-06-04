using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;

namespace Students.Queries;
public class GetStudentsQuery
{
    public List<Student> Handle()
    {
        return InMemoryStudentRepository.Students.Values.ToList();
    }
}