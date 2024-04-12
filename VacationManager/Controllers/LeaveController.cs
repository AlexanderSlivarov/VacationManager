using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VacationManager.Data;
using VacationManager.Data.Models;
using VacationManager.Models.Leave;
using VacationManager.Models.Team;

namespace VacationManager.Controllers
{
    public class LeaveController : Controller
    {
        private readonly VacationManagerDbContext _data;

        public LeaveController(VacationManagerDbContext context)
        {
            _data = context;
        }

        private string GetUserId()
            => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public async Task<IActionResult> All()
        {
            var leaves = await _data
                .Leaves
                .Select(l => new LeaveViewModel()
                {
                    Id = l.Id,
                    Type = l.Type,
                    DateFrom = l.DateFrom,
                    DateTo = l.DateTo,
                    CreationDate = DateTime.Now
                })
                .ToListAsync();

            return View(leaves);
        }

        public async Task<IActionResult> Create()
        {            
            return View(new LeaveFormModel());
        }

        [HttpPost]

        public async Task<IActionResult> Create(LeaveFormModel leaveModel)
        {
            if (ModelState.IsValid)
            {
                return View(leaveModel);
            }

            string currentUserId = GetUserId();

            Leave leave = new Leave()
            {
                Type = leaveModel.Type,
                DateFrom = leaveModel.DateFrom,
                DateTo = leaveModel.DateTo,
                CreationDate = DateTime.Now,
                ApplicantId = currentUserId,
                HalfDay = leaveModel.HalfDay,
                Approved = leaveModel.Approved                
            };

            await _data.Leaves.AddAsync(leave);
            await _data.SaveChangesAsync();

            return RedirectToAction("All", "Leave");
        }

        public async Task<IActionResult> Details(int id)
        {
            var leave = await _data
                .Leaves
                .Where(l => l.Id == id)
                .Select(l => new LeaveDetailsViewModel()
                {
                    Type = l.Type,
                    DateFrom = l.DateFrom,
                    DateTo = l.DateTo,
                    HalfDay = l.HalfDay,
                    Approved = l.Approved,
                    CreationDate = l.CreationDate                    
                })
                .FirstOrDefaultAsync();

            if (leave == null)
            {
                return BadRequest();
            }

            return View(leave);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var leave = await _data.Leaves.FindAsync(id);

            if (leave == null)
            {
                return BadRequest();
            }                       

            LeaveFormModel leaveModel = new LeaveFormModel()
            {
                Type = leave.Type,
                DateFrom = leave.DateFrom,
                DateTo = leave.DateTo,
                CreationDate = leave.CreationDate,  
                HalfDay = leave.HalfDay,
                Approved = leave.Approved
            };

            return View(leaveModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, LeaveFormModel leaveModel)
        {
            var leave = await _data.Leaves.FindAsync(id);

            if (leave == null)
            {
                return BadRequest();
            }         
                       
            if (ModelState.IsValid)
            {                
                return View(leaveModel);
            }

            leave.Type = leaveModel.Type;
            leave.DateFrom = leaveModel.DateFrom;
            leave.DateTo = leaveModel.DateTo;

            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Leave");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var leave = await _data.Leaves.FindAsync(id);

            if (leave == null)
            {
                return BadRequest();
            }            

            LeaveViewModel leaveModel = new LeaveViewModel()
            {
                Id = leave.Id,
                Type = leave.Type
            };

            return View(leaveModel);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(LeaveViewModel leaveModel)
        {
            var leave = await _data.Leaves.FindAsync(leaveModel.Id);

            if (leave == null)
            {
                return BadRequest();
            }            

            _data.Leaves.Remove(leave);
            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Leave");
        }
    }
}
