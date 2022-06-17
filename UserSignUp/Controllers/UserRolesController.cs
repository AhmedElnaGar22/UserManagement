using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserSignUp.Dto;

namespace UserSignUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly DataContext _context;
        public UserRolesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddRolePermisson(PermissonRoleDto permissonRoleDto)
        {
            var permissonRole = new PermissonRole
            {
                Permisson_Id = permissonRoleDto.Permisson_Id,
                Role_Id = permissonRoleDto.Role_Id
            };

            _context.permissonRoles.Add(permissonRole);
            await _context.SaveChangesAsync();

            return Ok("Permisson Role Added Successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRolePermisson(int Id)
        {
           var role = await _context.permissonRoles.FindAsync(Id);

            _context.permissonRoles.Remove(role);
            await _context.SaveChangesAsync();

            return Ok("Permisson Role Deleted Successfully!");
        }
    }
}
