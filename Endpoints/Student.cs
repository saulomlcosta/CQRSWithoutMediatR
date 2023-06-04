using CQRSWithoutMediatR.Entities;
using CQRSWithoutMediatR.Repositories;
using Students.Commands;
using Students.Queries;

namespace CQRSWithoutMediatR.Endpoints
{
    public static class Students
    {
        public static void AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("students", () =>
            {
                return Results.Ok(new GetStudentsQuery().Handle());
            });

            app.MapGet("students/{id}", (Guid id) =>
            {
                return Results.Ok(new GetStudentByIdQuery().Handle(id));
            });

            app.MapPost("students", (Student student) =>
            {
                new AddStudentCommand().Handle(student);

                return Results.Ok();
            });

            app.MapPut("students", (Student student) =>
            {
                new UpdateStudentCommand().Handle(student);

                return Results.NoContent();
            });

            app.MapDelete("students/{id}", (Guid id) =>
            {
                new DeleteStudentCommand().Handle(id);

                return Results.NoContent();
            });
        }
    }
}