namespace BlazorCourse.Models;

public class Developer
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}