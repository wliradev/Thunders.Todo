using Microsoft.Extensions.DependencyInjection;
using Thunders.Todo.Application.UseCases.Todo.CompleteTask;
using Thunders.Todo.Application.UseCases.Todo.CompleteTask.Commands;
using Thunders.Todo.Application.UseCases.Todo.CreateTask;
using Thunders.Todo.Application.UseCases.Todo.CreateTask.Commands;
using Thunders.Todo.Application.UseCases.Todo.DeleteTask;
using Thunders.Todo.Application.UseCases.Todo.DeleteTask.Commands;
using Thunders.Todo.Application.UseCases.Todo.GetTaskById;
using Thunders.Todo.Application.UseCases.Todo.GetTaskById.Queries;
using Thunders.Todo.Application.UseCases.Todo.ListAllTasks;
using Thunders.Todo.Application.UseCases.Todo.ListAllTasks.Queries;
using Thunders.Todo.Application.UseCases.Todo.UpdateTask;
using Thunders.Todo.Application.UseCases.Todo.UpdateTask.Commands;

namespace Thunders.Todo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddTransient<ICreateTaskCommand, CreateTaskCommand>();
            services.AddTransient<ICreateTaskUseCase, CreateTaskUseCase>();

            services.AddTransient<ICompleteTaskCommand, CompleteTaskCommand>();
            services.AddTransient<ICompleteTaskUseCase, CompleteTaskUseCase>();            
            
            services.AddTransient<ICreateTaskCommand, CreateTaskCommand>();
            services.AddTransient<ICreateTaskUseCase, CreateTaskUseCase>();

            services.AddTransient<IDeleteTaskCommand, DeleteTaskCommand>();
            services.AddTransient<IDeleteTaskUseCase, DeleteTaskUseCase>();

            services.AddTransient<IGetTaskByIdQuery, GetTaskByIdQuery>();
            services.AddTransient<IGetTaskByIdUseCase, GetTaskByIdUseCase>();

            services.AddTransient<IListAllTasksQuery, ListAllTasksQuery>();
            services.AddTransient<IListAllTasksUseCase, ListAllTasksUseCase>();

            services.AddTransient<IUpdateTaskCommand, UpdateTaskCommand>();
            services.AddTransient<IUpdateTaskUseCase, UpdateTaskUseCase>();

            return services;
        }
    }
}
