using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo.UpdateTask.Commands;

public interface IUpdateTaskCommand
{
    Task ExecuteAsync(TodoTask item);
}