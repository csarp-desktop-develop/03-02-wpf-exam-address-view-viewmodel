using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student, StudentDto>
    {
        private readonly IStudentRepo repo;
        public StudentController(StudentAssambler assembler, IStudentRepo repo) : base(assembler, repo)
        {
            this.repo = repo;
        }
    }
}
