using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Branches_Practice
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentservice;

        public StudentController (IStudentServices studentservice)
        {
            _studentservice = studentservice;
        }

        [HttpGet("GetAll")]

        public ActionResult<List<string>> StudentGetAll()
        {
            return Ok(_studentservice.StudentsGetAll());
        }

        [HttpGet("GetCount")]

        public ActionResult<int> GetCount()
        {
            return Ok(_studentservice.StudentCount());
        }
    }
}