using Thunders.Todo.Infra.Context;

namespace Thunders.Todo.Application.UseCases.Todo.DeleteTask.Commands;

public sealed class DeleteTaskCommand(TodoDbContext context) : IDeleteTaskCommand
{
    public async Task ExecuteAsync(Guid id)
    {
        var todoTaskDb = await context.TodoTasks.FindAsync(id);

        if (todoTaskDb is null)
            throw new ArgumentException($"Tarefa com ID {id} não encontrada."); ;

        context.TodoTasks.Remove(todoTaskDb);
        await context.SaveChangesAsync();
    }
}