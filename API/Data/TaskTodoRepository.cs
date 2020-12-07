using System.Collections.Generic;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TaskTodoRepository : ITaskTodoRepository
        private readonly DataContext _context;

        public TaskTodoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<TaskTodo> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id); 
        }

        public async Task<IEnumerable<TaskTodo>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(TaskTodo task)
        {
            _context.Entry(task).State = EntityState.Modified;
        }
        
    }
}