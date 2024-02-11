namespace Project;

public class TaskService
{
    List<Task> _tasks = new List<Task>();
    public List<Task> GetTask()
    {
        return _tasks;
    }
    public void AddTask(Task user)
    {
        _tasks.Add(user);
    }
    public void UpdateTask(Task user)
    {
        var a = _tasks.FirstOrDefault(p => p.TaskId == user.TaskId);
        a.Title = user.Title;
        a.Description = user.Description;
        a.Assignee = user.Assignee;
        a.TaskCategory = user.TaskCategory;
        a.TaskPriority = user.TaskPriority;
        a.Done = user.Done;
        a.CreatedAt = user.CreatedAt;
    }
    public void DeleteTask(int id)
    {
        var a = _tasks.FirstOrDefault(p => p.TaskId == id);
        _tasks.Remove(a);
    }
    public void ChangeStatusTrueTaskById(int id)
    {
        var a = _tasks.FirstOrDefault(p => p.TaskId == id);
        a.Done=true;

    }
      public void ChangeStatusFalseTaskById(int id)
    {
        var a = _tasks.FirstOrDefault(p => p.TaskId == id);
        a.Done=false;

    }
}
