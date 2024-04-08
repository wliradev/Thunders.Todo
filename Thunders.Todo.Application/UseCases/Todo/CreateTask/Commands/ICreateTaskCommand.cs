using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo.CreateTask.Commands;

public interface ICreateTaskCommand
{
    Task<TodoTask> ExecuteAsync(TodoTask item);
}