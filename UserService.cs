namespace Project;

public class UserService
{
    List<User> _users = new();
    public List<User> GetUsers()
    {
        return _users;
    }
    public User GetUserById(int id)
    {
        return _users.FirstOrDefault(p=>p.UserId==id);
    }
    public void AddUser(User user)
    {
        _users.Add(user);
    }
    public void UpdateUser(User user)
    {
        var a = _users.FirstOrDefault(p => p.UserId == user.UserId);
        a.UserName = user.UserName;
    }
    public void DeleteUser(int id)
    {
        var a = _users.FirstOrDefault(p => p.UserId == id);
        _users.Remove(a);
    }
}
