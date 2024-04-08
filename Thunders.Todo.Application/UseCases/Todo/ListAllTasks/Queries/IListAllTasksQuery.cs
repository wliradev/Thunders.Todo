using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo.ListAllTasks.Queries
{
    public interface IListAllTasksQuery
    {
        Task<IEnumerable<TodoTask>> ExecuteAsync();
    }
}