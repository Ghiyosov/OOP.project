namespace Project;

public class TaskManager
{
    List<Task> _tasks = new();
    List<User> _users = new();
    List<Category> _catigories = new();
    public TaskManager(List<Task> tasks, List<User> users, List<Category> categories)
    {
        _tasks = tasks;
        _users = users;
        _catigories = categories;
    }

    public List<Task> GetAllTask()
    {
        return _tasks;
    }
    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }
    public Task GetTaskById(int id)
    {
        var task = _tasks.FirstOrDefault(p => p.TaskId == id);
        return task;
    }
    public void UpdateTask(Task task)
    {
        var update = _tasks.FirstOrDefault(p => p.TaskId == task.TaskId);
        update.Title = task.Title;
        update.Description = task.Description;
        update.Assignee = task.Assignee;
        update.TaskCategory = task.TaskCategory;
        update.TaskPriority = task.TaskPriority;
        update.Done = task.Done;
        update.CreatedAt = task.CreatedAt;
    }
    public void DeleteTask(int id)
    {
        var task = _tasks.FirstOrDefault(p => p.TaskId == id);
        _tasks.Remove(task);
    }
    public void GetInfoAboutTasks()
    {
        foreach (var item in _tasks)
        {
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine("-------------------");
        }
    }
    public List<Task> GetCompletedTasks()
    {
        return _tasks.Where(p => p.Done == true).ToList();
    }
    public List<Task> GetNotCompletedTasks()
    {
        return _tasks.Where(p => p.Done == false).ToList();
    }
    public List<Task> GetTasksByCategoryId(int id)
    {
        return _tasks.Where(p => p.TaskCategory.CategoruId == id).ToList();
    }
    public List<Task> GetSortedTasks(List<Task> tasks)
    {
        var sort = from i in tasks orderby i.CreatedAt descending select i;
        return sort.ToList();
    }
    public List<Task> GetTasksByPriority(Priority priority)
    {
        return _tasks.Where(p => p.TaskPriority == priority).ToList();

    }
}
