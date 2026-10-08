using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_makarevich.Data;
using wt_lab5_5razor_makarevich.Models;

namespace wt_lab5_5razor_makarevich.Pages.Products;

public class EditModel : PageModel
{
    [BindProperty]
    public TaskItem Task { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = TaskStore.Tasks.FirstOrDefault(t => t.Id == id);
        if (existing == null)
            return NotFound();
        Task = existing;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        var existing = TaskStore.Tasks.FirstOrDefault(t => t.Id == Task.Id);
        if (existing == null)
            return NotFound();

        existing.Title = Task.Title;
        existing.Project = Task.Project;
        existing.Assignee = Task.Assignee;
        existing.EstimatedHours = Task.EstimatedHours;
        existing.IsCompleted = Task.IsCompleted;

        return RedirectToPage("./Index");
    }
}