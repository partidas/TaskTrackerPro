// TaskItem.cs defines the TaskItem mode
namespace TaskTracker.Data.Entities;

public class User
{
    public int Id { get; set; }     // Primary Key
    public string Username {get; set; } = ""; // Unique username
    public string PasswordHash { get; set; } = ""; // Hashed password

    // Navigation property: one user can have many tickets
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
}