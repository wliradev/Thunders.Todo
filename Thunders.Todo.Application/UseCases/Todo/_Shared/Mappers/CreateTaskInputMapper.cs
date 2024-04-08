using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo._Shared.Mappers;

public static class CreateTaskInputMapper
{
    public static TodoTask MapToTodoTask(this CreateTaskInput input) => TodoTask.Create(input.Title, input.Description);
}
