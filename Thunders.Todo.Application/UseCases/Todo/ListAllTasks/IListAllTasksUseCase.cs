using Thunders.Todo.Application.UseCases.Todo._Shared.Models;

namespace Thunders.Todo.Application.UseCases.Todo.ListAllTasks
{
    public interface IListAllTasksUseCase
    {
        Task<TaskResponse[]> ExecuteAsync();
    }
}