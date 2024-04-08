using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Application.UseCases.Todo._Shared.Mappers
{
    public static class TaskResponseMapper
    {
        public static TaskResponse MapToTaskResponse(this TodoTask input) => new()
        {
            Id = input.Id,
            Description = input.Description,
            Title = input.Title,
            CreateDateTime = input.CreateDateTime,
            IsCompleted = input.IsCompleted
        };
    }
}
