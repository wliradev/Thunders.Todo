using Microsoft.AspNetCore.Mvc;
using Thunders.Todo.Application.UseCases.Todo._Shared.Models;
using Thunders.Todo.Application.UseCases.Todo.CompleteTask;
using Thunders.Todo.Application.UseCases.Todo.CreateTask;
using Thunders.Todo.Application.UseCases.Todo.DeleteTask;
using Thunders.Todo.Application.UseCases.Todo.ListAllTasks;
using Thunders.Todo.Application.UseCases.Todo.UpdateTask;

namespace Thunders.Todo.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        public readonly IListAllTasksUseCase _listAllTasksUseCase;
        public readonly ICreateTaskUseCase _createTaskUseCase;
        public readonly IUpdateTaskUseCase _updateTaskUseCase;
        public readonly IDeleteTaskUseCase _deleteTaskUseCase;
        public readonly ICompleteTaskUseCase _completeTaskUseCase;

        public TodoController(IListAllTasksUseCase listAllTasksUseCase, 
                              ICreateTaskUseCase createTaskUseCase,
                              IUpdateTaskUseCase updateTaskUseCase,
                              IDeleteTaskUseCase deleteTaskUseCase,
                              ICompleteTaskUseCase completeTaskUseCase)
        {
            _listAllTasksUseCase = listAllTasksUseCase;
            _createTaskUseCase = createTaskUseCase;
            _updateTaskUseCase = updateTaskUseCase;
            _deleteTaskUseCase = deleteTaskUseCase;
            _completeTaskUseCase = completeTaskUseCase;
        }

        [HttpGet]
        public async Task<TaskResponse[]> ListAllTasksAsync() => 
            await _listAllTasksUseCase.ExecuteAsync();

        [HttpPost]
        public async Task<TaskResponse> CreateTaskAsync(CreateTaskInput input) => 
            await _createTaskUseCase.ExecuteAsync(input);

        [HttpPut]
        public async Task UpdateTaskAsync(TaskInput input) => 
            await _updateTaskUseCase.ExecuteAsync(input);

        [HttpPut]
        public async Task CompleteTaskAsync(Guid id) =>
             await _completeTaskUseCase.ExecuteAsync(id);

        [HttpDelete]
        public async Task DeleteTaskAsync(Guid id) => 
            await _deleteTaskUseCase.ExecuteAsync(id);
    }
}
