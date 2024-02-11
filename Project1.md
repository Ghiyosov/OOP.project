#   Project


**`User Class:`**

* **Represents a user in the task management system.**

* **Properties:**

    * *`UserId:`* Unique identifier for the user.

    * *`UserName:`* Name of the user.

    * *`Constructor:`* Initializes the UserId and UserName properties when a user object is created.

----

**`Category Class:`**

* **Represents a category for tasks, such as `Development` or `Design`.**

* **Properties:**
    * *`CategoryId:`* Unique identifier for the category.

    * *`CategoryName:`* Name of the category.

    * *`Constructor:`* Initializes the 
    *`CategoryId`* and *`CategoryName`* properties when a category object is created.

---

**`Task Class:`**

* **Represents a task in the task management system.**

* **Properties:**

    * *`TaskId:`* Unique identifier for the task.

    * *`Title:`* Title or name of the task.

    * *`Description:`* Description of the task.

    * *`Assignee:`* User assigned to the task (an instance of the User class).
    
    * *`TaskCategory:`* Category of the task (an instance of the Category class).

    * *`TaskPriority`* The priority level for the task.

    * *`Done`* A boolean indicating whether the task is completed.

    * *`CreatedAt:`* Date and time when the task was made.

    * *`Constructor:`* Initializes the `TaskId` , `Title` , `Description` , `Assignee` , `TaskCategory` , and `CreatedAt` properties when a task object is created.

---

**`TaskManager Class:`**

* **Manages tasks, users, categories, and comments in the task management system.**

* **Properties:**

    * *`tasks:`* List of tasks.

    * *`users:`* List of users.

    * *`categories:`* List of categories.

    * *`Constructor:`* Initializes the *`tasks`* , *`users`* , and *`categories`* lists when a *`TaskManager`* object is created.

---

**CRUD Operations:**

* *`GetAllTasks:`* Return all tasks.

* *`AddTask:`* Adds a task to the list of tasks.

* *`GetTaskById:`* Retrieves a task by its unique identifier.

* *`UpdateTask:`* Updates the properties of an existing task.

* *`DeleteTask:`* Removes a task from the list of tasks.

* *`GetInfoAboutTasks:`* Displays information about all tasks in the task manager.

* *`GetCompletedTasks:`* Return all completed tasks.

* *`GetNotCompletedTasks:`* Return all not completed tasks.

* *`GetTasksByCategoryId:`* Return all tasks by category id.

* *`GetSortedTasks:`* Return sorted tasks in descending order by `CreatedAt`.

* *`GetTasksByPriority:`* Return tasks by priority.

---

**Program Class (Main):**

* *`Example Usage:`*

    * Creates instances of *`User`* , *`Category`* , *`Task`* , and *`TaskManager`*.

    * Adds a task to the task manager. 
    * Displays all tasks. 
    * Updates a task. 
    * Displays again. 
    * Deletes a task 
    * Displays the final list.


## 

#   Проект


**`User Class:`**

* **Представляет пользователя в системе управления задачами.**

* **Характеристики:**

    * *`UserId:`* Уникальный идентификатор пользователя.

    * *`UserName:`* Имя пользователя.

    * *`Constructor:`* Инициализирует свойства *`UserId`* и *`UserName`* при создании объекта пользователя.

----

**`Category Class:`**

* **Представляет категорию задач, например «Разработка» или «Дизайн».**

* **Характеристики:**
    * *`CategoryId:`* Уникальный идентификатор категории.

    * *`CategoryName:`* Имя категории.

    * *`Конструктор:`* Инициализирует
    Свойства *`CategoryId`* и *`CategoryName`* при создании объекта категории.

---

**`Task Class:`**

* **Представляет задачу в системе управления задачами.**

* **Характеристики:**

    * *`TaskId:`* Уникальный идентификатор задачи.

    * *`Title:`* Название или название задачи.

    * *`Description:`* Описание задачи.

    * *`Assignee:`* Пользователь, назначенный задаче (экземпляр класса User).
    
    * *`TaskCategory:`* Категория задачи (экземпляр класса Category).

    * *`TaskPriority`* Уровень приоритета задачи.

    * *`Done`* Логическое значение, указывающее, завершена ли задача.

    * *`CreatedAt:`* Дата и время создания задачи.

    * *`Constructor:`* Инициализирует свойства `TaskId` , `Title` , `Description` , `Assignee` , `TaskCategory` и `CreatedAt` при создании объекта задачи.

---

**`TaskManager Class:`**

* **Управляет задачами, пользователями, категориями и комментариями в системе управления задачами.**

* **Характеристики:**

    * *`tasks:`* Список задач.

    * *`users:`* Список пользователей.

    * *`categories:`* Список категорий.

    * *`Constructor:`* Инициализирует списки *`tasks`* , *`users`* и *`categories`* при создании объекта *`TaskManager`*.

---

**Операции CRUD:**

* *`GetAllTasks:`* Возвращает все задачи.

* *`AddTask:`* Добавляет задачу в список задач.

* *`GetTaskById:`* Извлекает задачу по ее уникальному идентификатору.

* *`UpdateTask:`* Обновляет свойства существующей задачи.

* *`DeleteTask:`* Удаляет задачу из списка задач.

* *`GetInfoAboutTasks:`* Отображает информацию обо всех задачах в диспетчере задач.

* *`GetCompletedTasks:`* Возвращает все выполненные задачи.

* *`GetNotCompletedTasks:`* Возвращает все незавершенные задачи.

* *`GetTasksByCategoryId:`* Возвращает все задачи по идентификатору категории.

* *`GetSortedTasks:`* Возвращает отсортированные задачи в порядке убывания по `CreatedAt`.

* *`GetTasksByPriority:`* Возвращает задачи по приоритету.

---

**Класс программы (Основной):**

* *`Пример использования:`*

    * Создает экземпляры *`User`* , *`Category`* , *`Task`* и *`TaskManager`* .

    * Добавляет задачу в диспетчер задач.
    * Отображает все задачи.
    * Обновляет задачу.
    * Отображается снова.
    * Удаляет задачу
    * Отображает окончательный список.