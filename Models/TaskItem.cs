using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_makarevich.Models;

public class TaskItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите название задачи")]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите проект")]
    public string Project { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите исполнителя")]
    public string Assignee { get; set; } = string.Empty;

    [Range(1, 1000, ErrorMessage = "Часы от 1 до 1000")]
    public int EstimatedHours { get; set; }

    public bool IsCompleted { get; set; }
}