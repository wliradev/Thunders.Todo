using Thunders.Todo.Application.UseCases.Todo.DeleteTask.Commands;

namespace Thunders.Todo.Application.UseCases.Todo.DeleteTask;

public sealed class DeleteTaskUseCase(IDeleteTaskCommand deleteTaskCommand) : IDeleteTaskUseCase
{
    public async Task ExecuteAsync(Guid id) => await deleteTaskCommand.ExecuteAsync(id);
}