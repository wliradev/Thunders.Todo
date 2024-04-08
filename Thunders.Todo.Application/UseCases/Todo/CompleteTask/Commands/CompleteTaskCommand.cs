using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.CompleteTask.Commands;

public class CompleteTaskCommand(TodoDbContext context) : ICompleteTaskCommand
{
    public async Task ExecuteAsync(Guid id)
    {
        var todoTaskDb = await context.TodoTasks.FindAsync(id);

        if (todoTaskDb is null)
            throw new ArgumentException($"Tarefa com ID {id} não encontrada.");

        todoTaskDb.Complete();
        await context.SaveChangesAsync();
    }
}