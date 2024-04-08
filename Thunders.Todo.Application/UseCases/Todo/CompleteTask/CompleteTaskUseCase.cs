using Thunders.Todo.Application.UseCases.Todo.CompleteTask.Commands;

namespace Thunders.Todo.Application.UseCases.Todo.CompleteTask;

public sealed class CompleteTaskUseCase(ICompleteTaskCommand completeTaskCommand) : ICompleteTaskUseCase
{
    public async Task ExecuteAsync(Guid id) => await completeTaskCommand.ExecuteAsync(id);
}
