using Microsoft.EntityFrameworkCore;
using Thunders.Todo.Domain.Entities;
using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.ListAllTasks.Queries;

public class ListAllTasksQuery(TodoDbContext context) : IListAllTasksQuery
{
    public async Task<IEnumerable<TodoTask>> ExecuteAsync()
    {
        return await context.TodoTasks.ToListAsync();
    }
}