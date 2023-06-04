using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;

namespace CQRSWithoutMediatR.Endpoints
{
    public static class Students
    {
        public static void AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("students", (InMemoryStudentRepository repository) =>
            {
                return Results.Ok(repository.Get());
            });

            app.MapGet("students/{id}", (Guid id, InMemoryStudentRepository repository) =>
            {
                return Results.Ok(repository.GetById(id));
            });

            app.MapPost("students", (Student student, InMemoryStudentRepository repository) =>
            {
                repository.Add(student);

                return Results.Ok();
            });

            app.MapPut("students", (Student student, InMemoryStudentRepository repository) =>
            {
                repository.Update(student);

                return Results.NoContent();
            });

            app.MapDelete("students/{id}", (Guid id, InMemoryStudentRepository repository) =>
            {
                repository.Delete(id);

                return Results.NoContent();
            });
        }
    }
}