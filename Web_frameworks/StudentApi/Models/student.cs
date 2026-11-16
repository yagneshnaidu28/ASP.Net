using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public int Age { get; set; }
}