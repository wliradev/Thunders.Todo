using Thunders.Todo.Application.UseCases.Todo._Shared.Models;

namespace Thunders.Todo.Application.UseCases.Todo.GetTaskById;

public interface IGetTaskByIdUseCase
{
    Task<TaskResponse?> ExecuteAsync(Guid id);
}