using Thunders.Todo.Application.UseCases.Todo._Shared.Models;

namespace Thunders.Todo.Application.UseCases.Todo.CreateTask;

public interface ICreateTaskUseCase
{
    Task<TaskResponse> ExecuteAsync(CreateTaskInput input);
}