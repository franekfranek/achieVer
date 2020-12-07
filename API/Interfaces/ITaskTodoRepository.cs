using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
    public interface ITaskTodoRepository
    {
        void Update(TaskTodo task);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<TaskTodo>> GetTasksAsync();
        Task<TaskTodo> GetTaskByIdAsync(int id);
    }
}