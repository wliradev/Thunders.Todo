
namespace Thunders.Todo.Application.UseCases.Todo.CompleteTask;

public interface ICompleteTaskUseCase
{
    Task ExecuteAsync(Guid id);
}