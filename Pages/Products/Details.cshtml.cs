using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_makarevich.Data;
using wt_lab5_5razor_makarevich.Models;

namespace wt_lab5_5razor_makarevich.Pages.Products;

public class DetailsModel : PageModel
{
    public TaskItem Task { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var found = TaskStore.Tasks.FirstOrDefault(t => t.Id == id);
        if (found == null)
            return NotFound();
        Task = found;
        return Page();
    }
}