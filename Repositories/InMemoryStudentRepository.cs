using CQRSWithoutMediatR.Entities;

namespace CQRSWithoutMediatR.Repositories;

public class InMemoryStudentRepository
{
    public static readonly Dictionary<Guid, Student> Students = new();
}