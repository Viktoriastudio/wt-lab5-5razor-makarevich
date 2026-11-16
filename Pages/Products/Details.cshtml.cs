using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_makarevich.Data;
using wt_lab8_8razor_postgresql_makarevich.Models;

namespace wt_lab8_8razor_postgresql_makarevich.Pages.Products;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;
    public DetailsModel(AppDbContext context) => _context = context;

    public Product Product { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null) return NotFound();
        Product = await _context.Products.FindAsync(id);
        if (Product == null) return NotFound();
        return Page();
    }
}