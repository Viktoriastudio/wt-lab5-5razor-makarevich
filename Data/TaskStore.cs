using wt_lab5_5razor_makarevich.Models;

namespace wt_lab5_5razor_makarevich.Data;

public static class TaskStore
{
    public static List<TaskItem> Tasks { get; } = new()
    {
        new TaskItem { Id = 1, Title = "Сбор требований", Project = "CRM для банка", Assignee = "Ольга Смирнова", EstimatedHours = 16, IsCompleted = true },
        new TaskItem { Id = 2, Title = "Проектирование БД", Project = "CRM для банка", Assignee = "Иван Петров", EstimatedHours = 24, IsCompleted = true },
        new TaskItem { Id = 3, Title = "Разработка API", Project = "CRM для банка", Assignee = "Иван Петров", EstimatedHours = 40, IsCompleted = false },
        new TaskItem { Id = 4, Title = "Тестирование", Project = "CRM для банка", Assignee = "Пётр Иванов", EstimatedHours = 20, IsCompleted = false },
        new TaskItem { Id = 5, Title = "Деплой", Project = "Мобильное приложение", Assignee = "Дмитрий Козлов", EstimatedHours = 8, IsCompleted = false }
    };
}