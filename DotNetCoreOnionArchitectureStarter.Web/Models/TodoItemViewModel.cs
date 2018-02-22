using System.ComponentModel.DataAnnotations;
using DotNetCoreOnionArchitectureStarter.Core.Entities;

namespace DotNetCoreOnionArchitectureStarter.Web.Models
{
    public class TodoItemViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public static TodoItemViewModel FromTodoItem(TodoItem item)
        {
            return new TodoItemViewModel
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                IsDone = item.IsDone
            };
        }
    }
}