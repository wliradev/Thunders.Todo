
namespace Thunders.Todo.Application.UseCases.Todo.DeleteTask;

public interface IDeleteTaskUseCase
{
    Task ExecuteAsync(Guid id);
}