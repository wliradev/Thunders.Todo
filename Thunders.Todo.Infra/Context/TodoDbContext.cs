using Microsoft.EntityFrameworkCore;
using Thunders.Todo.Domain.Entities;

namespace Thunders.Todo.Infra.Context;

public class TodoDbContext : DbContext
{
    public DbSet<TodoTask> TodoTasks { get; set; }

    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
        if (Database.EnsureCreated())
        {
            SeedData();
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();

        base.OnConfiguring(optionsBuilder);
    }

    private void SeedData()
    {
        TodoTasks.Add(TodoTask.Create("Fazer compras", "Comprar leite, ovos e pão"));
        TodoTasks.Add(TodoTask.Create("Estudar para a prova", "Revisar os conceitos principais"));

        SaveChanges();
    }
}