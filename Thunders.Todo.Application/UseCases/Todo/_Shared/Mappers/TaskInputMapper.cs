using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo._Shared.Mappers
{
    public static class TaskInputMapper
    {
        public static TodoTask MapToTodoTask(this TaskInput input) => new(input.Title, input.Description)
        {
            Id = input.Id,
        };
    }
}
