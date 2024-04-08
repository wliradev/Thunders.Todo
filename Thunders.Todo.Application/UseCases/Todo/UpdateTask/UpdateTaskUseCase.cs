using Thunders.Todo.Application.UseCases.Todo._Shared.Mappers;
using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Application.UseCases.Todo.UpdateTask.Commands;

namespace Thunders.Todo.Application.UseCases.Todo.UpdateTask;

public sealed class UpdateTaskUseCase(IUpdateTaskCommand updateTaskCommand) : IUpdateTaskUseCase
{
    public async Task ExecuteAsync(TaskInput input) =>
        await updateTaskCommand.ExecuteAsync(input.MapToTodoTask());
}