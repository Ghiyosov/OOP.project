


using System.Data.Common;
using Project;

User user1 = new User(1, "Ismoil");
User user2 = new User(2, "Abdullo");
User user3 = new User(3, "Giyosov");
Category category1 = new Category(1, "important");
Category category2 = new Category(2, "urgent");
Category category3 = new Category(3, "noImportant");
Category category4 = new Category(4, "noUrgent");
Project.Task task1 = new Project.Task(1, "homeWork", "do homevork", user1, category1, new DateTime(2024, 02, 11));
task1.Done = false;
task1.TaskPriority = Priority.High;
Project.Task task2 = new Project.Task(2, "book", "read book", user2, category3, new DateTime(2024, 01, 11));
task1.Done = true;
task2.TaskPriority = Priority.Medium;
Project.Task task3 = new Project.Task(3, "project", "creat project", user3, category4, new DateTime(2024, 02, 11));
task1.Done = false;

UserService userService = new UserService();
userService.AddUser(user1);
userService.AddUser(user2);
userService.AddUser(user3);

CategoryService categoryService = new CategoryService();
categoryService.AddCatigory(category1);
categoryService.AddCatigory(category2);
categoryService.AddCatigory(category3);
categoryService.AddCatigory(category4);

TaskService taskService = new TaskService();
taskService.AddTask(task1);
taskService.AddTask(task2);
taskService.AddTask(task3);

TaskManager taskManager = new TaskManager(taskService.GetTask(), userService.GetUsers(), categoryService.GetCategories());

while (true)
{
    System.Console.WriteLine("---------Hello----------");
    System.Console.WriteLine("For show tasks, enter task");
    System.Console.WriteLine("For show users, enter user");
    System.Console.WriteLine("For show catigories, enter catigory");
    System.Console.WriteLine("For go to Task Maneger, enter manager");
    System.Console.WriteLine("For exit, enter exit");
    string enter = Console.ReadLine();
    enter.ToLower();
    if (enter == "exit") return;
    else if (enter == "task")
    {
        System.Console.WriteLine("***************************");
        System.Console.WriteLine("We have :");
        foreach (var item in taskService.GetTask())
        {
            System.Console.WriteLine(item.TaskId);
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine(item.Assignee.UserName);
            System.Console.WriteLine(item.TaskPriority);
            System.Console.WriteLine(item.TaskCategory);
            System.Console.WriteLine(item.CreatedAt);
            System.Console.WriteLine("-----------------------");
        }
        System.Console.WriteLine("For add task, enter add");
        System.Console.WriteLine("For update task, enter update");
        System.Console.WriteLine("For delete task, enter delete");
        System.Console.WriteLine("For exit, enter exit");
        string t = Console.ReadLine();
        t = t.ToLower();
        if (t == "add")
        {
            System.Console.WriteLine("Add new task");
            System.Console.Write("Task Id : ");
            int tasId = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Title : ");
            string title = Console.ReadLine();
            System.Console.Write("Description : ");
            string des = Console.ReadLine();
            System.Console.Write("Assignee ID : ");
            int asId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Task categoriy ID :");
            int ctId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Task Priority (low, medium, hight) :");
            string priority = Console.ReadLine();
            priority = priority.ToLower();
            Priority pris;
            if (priority == "low") pris = Priority.Low;
            else if (priority == "medium") pris = Priority.Medium;
            else if (priority == "hight") pris = Priority.High;
            else pris = Priority.Low;
            System.Console.WriteLine("Created At : ");
            DateTime date = Convert.ToDateTime(Console.ReadLine);
            var newTask = new Project.Task()
            {
                TaskId = tasId,
                Title = title,
                Description = des,
                TaskCategory = categoryService.GetByIdCatigory(ctId),
                Assignee = userService.GetUserById(asId),
                TaskPriority = pris,
                CreatedAt = date,
            };
            taskService.AddTask(newTask);
            if (newTask != null) System.Console.WriteLine("New Task add succesiful");
        }
        else if (t == "update")
        {
            System.Console.WriteLine("Update task");
            System.Console.Write("Task Id : ");
            int tasId = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Title : ");
            string title = Console.ReadLine();
            System.Console.Write("Description : ");
            string des = Console.ReadLine();
            System.Console.Write("Assignee ID : ");
            int asId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Task categoriy ID :");
            int ctId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Task Priority (low, medium, hight) :");
            string priority = Console.ReadLine();
            priority = priority.ToLower();
            Priority pris;
            if (priority == "low") pris = Priority.Low;
            else if (priority == "medium") pris = Priority.Medium;
            else if (priority == "hight") pris = Priority.High;
            else pris = Priority.Low;
            System.Console.WriteLine("Created At : ");
            DateTime date = Convert.ToDateTime(Console.ReadLine);
            var newTask = new Project.Task()
            {
                TaskId = tasId,
                Title = title,
                Description = des,
                TaskCategory = categoryService.GetByIdCatigory(ctId),
                Assignee = userService.GetUserById(asId),
                TaskPriority = pris,
                CreatedAt = date,
            };
            taskService.UpdateTask(newTask);
            if (newTask != null) System.Console.WriteLine("Task Update succesiful");


        }
        else if (t == "delete")
        {
            System.Console.WriteLine("ID of the one to be deleted Task : ");
            int id = Convert.ToInt32(Console.ReadLine());
            taskService.DeleteTask(id);
            System.Console.WriteLine("Task deleted succesiful");
        }
        else continue;
    }
    else if (enter == "user")
    {
        System.Console.WriteLine("We have : ");
        foreach (var item in userService.GetUsers())
        {
            System.Console.WriteLine(item.UserId);
            System.Console.WriteLine(item.UserName);
            System.Console.WriteLine("-----------------------------");
        }
        System.Console.WriteLine("For add user, enter add");
        System.Console.WriteLine("For update user, enter update");
        System.Console.WriteLine("For delete user, enter delete");
        System.Console.WriteLine("For exit, enter exit");
        string use = Console.ReadLine();
        use = use.ToLower();
        if (use == "add")
        {
            System.Console.WriteLine("Id :");
            int newId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("user name : ");
            string newName = Console.ReadLine();
            var newUser = new User(newId, newName);
            userService.AddUser(newUser);
            System.Console.WriteLine("New user add succesifel");
        }
        else if (use == "update")
        {
            System.Console.WriteLine("Id :");
            int newId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("user name : ");
            string newName = Console.ReadLine();
            var newUser = new User(newId, newName);
            userService.UpdateUser(newUser);
            System.Console.WriteLine("User update succesiful");
        }
        else if (use == "delete")
        {
            System.Console.WriteLine("Deleted user ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            userService.DeleteUser(id);
            System.Console.WriteLine("User deleted succesiful");
        }
        else continue;


    }
    else if (enter == "catigory")
    {
        System.Console.WriteLine("We have : ");
        foreach (var item in categoryService.GetCategories())
        {
            System.Console.WriteLine(item.CategoruId);
            System.Console.WriteLine(item.CategoruName);
            System.Console.WriteLine("---------------------------");
        }
        System.Console.WriteLine("For add catigory, enter add");
        System.Console.WriteLine("For update catigory, enter update");
        System.Console.WriteLine("For delete catigory, enter delete");
        System.Console.WriteLine("For exit, enter exit");
        string cat = Console.ReadLine();
        cat = cat.ToLower();
        if (cat == "add")
        {
            System.Console.WriteLine("Id :");
            int newId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("catigory name : ");
            string newName = Console.ReadLine();
            var newUser = new Category(newId, newName);
            categoryService.AddCatigory(newUser);
            System.Console.WriteLine("New catigory add succesifel");
        }
        else if (cat == "update")
        {
            System.Console.WriteLine("Id :");
            int newId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Catigory name : ");
            string newName = Console.ReadLine();
            var newUser = new Category(newId, newName);
            categoryService.UdateCategory(newUser);
            System.Console.WriteLine("Catigory update succesiful");
        }
        else if (cat == "delete")
        {
            System.Console.WriteLine("Deleted catigory ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            categoryService.DeleteCategory(id);
            System.Console.WriteLine("Category deleted succesiful");
        }
        else continue;
    }
    else if (enter == "manager")
    {
        System.Console.WriteLine("For to change the status task to completed, enter status");
        System.Console.WriteLine("For return complated tasks, enter compl");
        System.Console.WriteLine("For return not complated tasks, enter not");
        System.Console.WriteLine("For return tasks by catigory ID enter : catigory");
        string mag = Console.ReadLine();
        mag = mag.ToLower();
        if (mag == "status")
        {
            System.Console.Write("Write changes task status TASK ID : ");
            int tasId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("will change to filled(yes), not filled(no) :");
            string fill = Console.ReadLine();
            fill = fill.ToLower();
            if (fill == "yes")
            {
                taskService.ChangeStatusTrueTaskById(tasId);
                System.Console.WriteLine("Task status is changed");
            }
            else if (fill == "no")
            {
                taskService.ChangeStatusFalseTaskById(tasId);
                System.Console.WriteLine("Task status is changed");
            }
            else continue;
        }
        if (mag == "compl")
        {
            foreach (var item in taskManager.GetCompletedTasks())
            {
                System.Console.WriteLine(item.TaskId);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Description);
                System.Console.WriteLine(item.CreatedAt);
                System.Console.WriteLine("--------------------------------");

            }
            System.Console.WriteLine("For descending order, enter order");
            string ord = Console.ReadLine();
            ord = ord.ToLower();
            if (ord == "order")
            {
                foreach (var item in taskManager.GetSortedTasks(taskManager.GetCompletedTasks()))
                {
                    System.Console.WriteLine(item.TaskId);
                    System.Console.WriteLine(item.Title);
                    System.Console.WriteLine(item.Description);
                    System.Console.WriteLine(item.CreatedAt);
                    System.Console.WriteLine("--------------------------------");
                }
            }
            else continue;
        }
        else if (mag == "not")
        {
            foreach (var item in taskManager.GetNotCompletedTasks())
            {
                System.Console.WriteLine(item.TaskId);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Description);
                System.Console.WriteLine(item.CreatedAt);
                System.Console.WriteLine("--------------------------------");
            }
            System.Console.WriteLine("For descending order, enter order");
            string ord = Console.ReadLine();
            ord = ord.ToLower();
            if (ord == "order")
            {
                foreach (var item in taskManager.GetSortedTasks(taskManager.GetNotCompletedTasks()))
                {
                    System.Console.WriteLine(item.TaskId);
                    System.Console.WriteLine(item.Title);
                    System.Console.WriteLine(item.Description);
                    System.Console.WriteLine(item.CreatedAt);
                    System.Console.WriteLine("--------------------------------");
                }
            }
            else continue;
        }
        else if (mag == "catigory")
        {
            System.Console.WriteLine("Write catigory ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in taskManager.GetTasksByCategoryId(id))
            {
                System.Console.WriteLine(item.TaskId);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Description);
                System.Console.WriteLine(item.CreatedAt);
                System.Console.WriteLine("--------------------------------");
            }
            System.Console.WriteLine("For descending order, enter order");
            string ord = Console.ReadLine();
            ord = ord.ToLower();
            if (ord == "order")
            {
                foreach (var item in taskManager.GetSortedTasks(taskManager.GetTasksByCategoryId(id)))
                {
                    System.Console.WriteLine(item.TaskId);
                    System.Console.WriteLine(item.Title);
                    System.Console.WriteLine(item.Description);
                    System.Console.WriteLine(item.CreatedAt);
                    System.Console.WriteLine("--------------------------------");
                }
            }
            else continue;
        }
    }


}

