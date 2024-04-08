using System.ComponentModel.DataAnnotations;

namespace Thunders.Todo.Domain.Entities;

public sealed class TodoTask(string title, string description)
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public bool IsCompleted { get; set; } = false;
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
    public DateTime? CompleteDateTime { get; set; }

    public void Complete()
    {
        IsCompleted = true;
        CompleteDateTime = DateTime.Now;
    }

    public static TodoTask Create(string title, string description)
    {
        return new TodoTask(title, description);
    }
}