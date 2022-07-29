using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScholarshipPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScholarshipPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        ScholarshipPortalContext db = new ScholarshipPortalContext();
         
        [HttpGet]
        [Route("StudentDetails")]
        public IActionResult GetStudentDetails()
        {
            var data = from d in db.Students select d;
            return Ok(data);
        }

        [HttpGet]
        [Route("StudentDetails/{id}")]
        public IActionResult GetStudentDetails(int? id)
        {
            if (id == null)
            {
                return BadRequest("id cannot be null");
            }
            var data = (from d in db.Students where d.StudentId == id select d).FirstOrDefault();
            if (data == null)
            {
                return NotFound($"Department {id} not present");
            }
            return Ok(data);
        }
    }
}
