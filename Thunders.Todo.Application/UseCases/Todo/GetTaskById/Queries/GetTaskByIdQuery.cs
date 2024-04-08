using Thunders.Todo.Domain.Entities;
using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.GetTaskById.Queries;

public sealed class GetTaskByIdQuery(TodoDbContext context) : IGetTaskByIdQuery
{
    public async Task<TodoTask?> ExecuteAsync(Guid id) => await context.TodoTasks.FindAsync(id);
}