namespace Thunders.Todo.Application.UseCases.Todo._Shared.Models
{
    public sealed class TaskInput
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
