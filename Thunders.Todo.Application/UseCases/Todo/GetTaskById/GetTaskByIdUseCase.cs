using Thunders.Todo.Application.UseCases.Todo._Shared.Mappers;
using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Application.UseCases.Todo.GetTaskById.Queries;

namespace Thunders.Todo.Application.UseCases.Todo.GetTaskById;
public sealed class GetTaskByIdUseCase(IGetTaskByIdQuery getTaskByIdQuery) : IGetTaskByIdUseCase
{
    public async Task<TaskResponse?> ExecuteAsync(Guid id) =>
        (await getTaskByIdQuery.ExecuteAsync(id))?.MapToTaskResponse();
}
