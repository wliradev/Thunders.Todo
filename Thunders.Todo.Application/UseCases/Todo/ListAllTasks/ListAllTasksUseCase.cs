using Thunders.Todo.Application.UseCases.Todo._Shared.Mappers;
using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Application.UseCases.Todo.ListAllTasks.Queries;

namespace Thunders.Todo.Application.UseCases.Todo.ListAllTasks;

public class ListAllTasksUseCase(IListAllTasksQuery listAllTasksQuery) : IListAllTasksUseCase
{
    public async Task<TaskResponse[]> ExecuteAsync() =>
        (await listAllTasksQuery.ExecuteAsync()).Select(it => it.MapToTaskResponse()).ToArray();
}
