using MediatR;
using Microsoft.AspNetCore.Mvc;
using Todo.Application.Features.Todos.CreateTodo;

namespace Todo.WebApimiz.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
                 /// primary constructor ozelliği c# 12 ile ve .net 8 il geldi
    public class TodosController(IMediator mediator) : ControllerBase
    {

      
        [HttpPost]
       public async Task<IActionResult> Create(CreateTodoCommand command,CancellationToken cancellationToken)
        {
            await mediator.Send(command,cancellationToken);
            return Created();
        }
    }
}
