using Thunders.Todo.Domain.Entities;
using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.CreateTask.Commands;

public sealed class CreateTaskCommand(TodoDbContext context) : ICreateTaskCommand
{
    public async Task<TodoTask> ExecuteAsync(TodoTask item)
    {
        await context.TodoTasks.AddAsync(item);
        await context.SaveChangesAsync();

        return item;
    }
}