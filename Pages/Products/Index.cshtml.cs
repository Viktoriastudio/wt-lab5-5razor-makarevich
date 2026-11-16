using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_makarevich.Data;
using wt_lab8_8razor_postgresql_makarevich.Models;
using Microsoft.AspNetCore.Mvc;

namespace wt_lab8_8razor_postgresql_makarevich.Pages.Products;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context) => _context = context;

    public List<Product> Products { get; set; } = new();

    [BindProperty(SupportsGet = true)]
    public string? Search { get; set; }

    public async Task OnGetAsync()
    {
        var query = _context.Products.AsQueryable();
        if (!string.IsNullOrWhiteSpace(Search))
            query = query.Where(p => p.Name.Contains(Search));
        Products = await query.OrderBy(p => p.Name).ToListAsync();
    }
}