using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VacationManager.Data;
using VacationManager.Data.Models;
using VacationManager.Models.User;

namespace VacationManager.Controllers
{
    public class UserController : Controller
    {
        private readonly VacationManagerDbContext _data;

        public UserController(VacationManagerDbContext context)
        {
            _data = context;
        }

        public async Task<IActionResult> All()
        {
            var user = await _data
                .Users
                .Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Role = u.Role
                })
                .ToListAsync();

            return View(user);
        }

        public async Task<IActionResult> Details(string id)
        {
            var user = await _data
                .Users
                .Where(u => u.Id == id)
                .Select(u => new UserDetailsViewModel()
                {
                    UserName = u.UserName,
                    Role = u.Role,
                    FirstName = u.FirstName,
                    LastName = u.LastName                    
                })
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return BadRequest();
            }

            return View(user);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _data.Users.FindAsync(id);

            if (user == null)
            {
                return BadRequest();
            }

            UserFormModel leaveModel = new UserFormModel()
            {
                UserName = user.UserName,
                Role = user.Role
            };

            return View(leaveModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(string id, UserFormModel userModel)
        {
            var user = await _data.Users.FindAsync(id);

            if (user == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
          
            user.UserName = userModel.UserName;
            user.Role = userModel.Role;

            await _data.SaveChangesAsync();
            return RedirectToAction("All", "User");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _data.Users.FindAsync(id);

            if (user == null)
            {
                return BadRequest();
            }

            UserViewModel leaveModel = new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Role = user.Role
            };

            return View(leaveModel);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(UserViewModel userModel)
        {
            var user = await _data.Users.FindAsync(userModel.Id);

            if (user == null)
            {
                return BadRequest();
            }

            _data.Users.Remove(user);
            await _data.SaveChangesAsync();
            return RedirectToAction("All", "User");
        }
    }
}
