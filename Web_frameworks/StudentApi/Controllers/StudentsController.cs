using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Models;

namespace StudentApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    // CREATE
    [HttpPost]
    public async Task<IActionResult> CreateStudent(Student student)
    {
        _context.Students.Add(student);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetStudent),
            new { id = student.Id },
            student
        );
    }

    // READ ALL
    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        var students = await _context.Students.ToListAsync();

        return Ok(students);
    }

    // READ BY ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound("Student not found");
        }

        return Ok(student);
    }

    // UPDATE
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(
        int id,
        Student updatedStudent)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound("Student not found");
        }

        student.Name = updatedStudent.Name;
        student.Email = updatedStudent.Email;
        student.Age = updatedStudent.Age;

        await _context.SaveChangesAsync();

        return Ok(student);
    }

    // DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound("Student not found");
        }

        _context.Students.Remove(student);

        await _context.SaveChangesAsync();

        return Ok("Student deleted successfully");
    }
}