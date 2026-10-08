using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_makarevich.Data;
using wt_lab5_5razor_makarevich.Models;

namespace wt_lab5_5razor_makarevich.Pages.Products;

public class CreateModel : PageModel
{
    [BindProperty]
    public TaskItem Task { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        Task.Id = TaskStore.Tasks.Any() ? TaskStore.Tasks.Max(t => t.Id) + 1 : 1;
        TaskStore.Tasks.Add(Task);
        return RedirectToPage("./Index");
    }
}