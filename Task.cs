namespace Project;

public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Assignee { get; set; }
    public Category TaskCategory { get; set; }
    public Priority TaskPriority { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
    public Task(int id, string title, string description, User assignee, Category category, DateTime createdAt)
    {
        TaskId = id;
        Title=title;
        Description = description;
        Assignee = assignee;
        TaskCategory = category;
        CreatedAt = createdAt;
    }
    public Task()
    {
        
    }
}
