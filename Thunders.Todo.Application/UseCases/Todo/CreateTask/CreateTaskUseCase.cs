using Thunders.Todo.Application.UseCases.Todo._Shared.Mappers;
using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Application.UseCases.Todo.CreateTask.Commands;

namespace Thunders.Todo.Application.UseCases.Todo.CreateTask;

public sealed class CreateTaskUseCase(ICreateTaskCommand createTaskCommand) : ICreateTaskUseCase
{
    public async Task<TaskResponse> ExecuteAsync(CreateTaskInput input)
    {
        var response = await createTaskCommand.ExecuteAsync(input.MapToTodoTask());
        return response.MapToTaskResponse();
    }
}