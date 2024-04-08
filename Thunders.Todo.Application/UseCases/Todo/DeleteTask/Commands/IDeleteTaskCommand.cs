
namespace Thunders.Todo.Application.UseCases.Todo.DeleteTask.Commands;

public interface IDeleteTaskCommand
{
    Task ExecuteAsync(Guid id);
}