using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_makarevich.Data;
using wt_lab5_5razor_makarevich.Models;

namespace wt_lab5_5razor_makarevich.Pages.Products;

public class IndexModel : PageModel
{
    public List<TaskItem> Tasks { get; set; } = new();

    public void OnGet()
    {
        Tasks = TaskStore.Tasks;
    }
}