using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo.GetTaskById.Queries;

public interface IGetTaskByIdQuery
{
    Task<TodoTask?> ExecuteAsync(Guid id);
}