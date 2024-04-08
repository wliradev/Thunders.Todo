using Thunders.Todo.Domain.Entities;
using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.UpdateTask.Commands;

public class UpdateTaskCommand(TodoDbContext context) : IUpdateTaskCommand
{
    public async Task ExecuteAsync(TodoTask item)
    {
        var todoTaskDb = await context.TodoTasks.FindAsync(item.Id);

        if (todoTaskDb is null)
            throw new ArgumentException($"Tarefa com ID {item.Id} não encontrada.");

        todoTaskDb.Title = item.Title;
        todoTaskDb.Description = item.Description;

        await context.SaveChangesAsync();
    }
}
