
namespace Thunders.Todo.Application.UseCases.Todo.CompleteTask.Commands;

public interface ICompleteTaskCommand
{
    Task ExecuteAsync(Guid id);
}