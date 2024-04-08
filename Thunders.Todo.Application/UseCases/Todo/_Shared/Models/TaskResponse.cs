namespace Thunders.Todo.Application.UseCases.Todo._Shared.Models;

public sealed class TaskResponse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreateDateTime { get; set; }
}