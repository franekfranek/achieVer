using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class TaskController : BaseApiController
    {
        private readonly ITaskTodoRepository _repo;

        public TaskController(ITaskTodoRepository repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskTodo>>> GetTasks()
        {
            return Ok(await _repo.GetTasksAsync());
        }
    }
}