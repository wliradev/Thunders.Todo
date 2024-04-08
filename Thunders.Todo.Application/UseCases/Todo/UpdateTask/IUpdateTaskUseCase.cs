using Thunders.Todo.Application.UseCases.Todo._Shared.Models;

namespace Thunders.Todo.Application.UseCases.Todo.UpdateTask
{
    public interface IUpdateTaskUseCase
    {
        Task ExecuteAsync(TaskInput input);
    }
}