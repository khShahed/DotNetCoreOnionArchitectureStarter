using System;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreOnionArchitectureStarter.Core.Entities;
using DotNetCoreOnionArchitectureStarter.Core.Interfaces;
using DotNetCoreOnionArchitectureStarter.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreOnionArchitectureStarter.Web.Api
{
    
    public class TodoItemsApiController : Controller
    {
        private readonly IRepository<TodoItem> _todoRepository;

        public TodoItemsApiController(IRepository<TodoItem> todoRepository)
        {
            _todoRepository = todoRepository;
        }
        
        // GET api/Todos
        [HttpGet("api/Todos")]
        public async Task<IActionResult> GetAll()
        {
            var items = await _todoRepository.GetAll();
            return Ok(items.Select(TodoItemViewModel.FromTodoItem));
        }
        
        // GET
        [HttpGet("api/Todos/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var todoItem = await _todoRepository.GetById(id);
                return Ok(TodoItemViewModel.FromTodoItem(todoItem));
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}