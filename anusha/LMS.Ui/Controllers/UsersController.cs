using LMS.Application.Common.Models.Users;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Ui.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            var users = await _userService.ListAsync(cancellationToken);
            return View(users);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View(new CreateUserVM());
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] CreateUserVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var userVM = new UserVM
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                };
                await _userService.CreateAsync(userVM, cancellationToken);
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(int id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetAsync(id, cancellationToken);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> Edit(UserVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateAsync(model.Id, model, cancellationToken);
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetAsync(id, cancellationToken);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetAsync(id, cancellationToken);
            if (user == null)
            {
                return NotFound();
            }
            await _userService.DeleteAsync(id, cancellationToken);
            return RedirectToAction("List");
        }
    }
}
