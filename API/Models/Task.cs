using System;

namespace API.Models
{
    public class TaskTodo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public int Time { get; set; }
        public DateTime Finished { get; set; }
        public bool IsDone { get; set; }
        public AppUser Creator { get; set; }

        
    }
}