using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Index : PageModel
{
    public List<Category> CategoryList { get; set; } = new();

    public async Task<IActionResult> OnGet()
    {
        await Task.Delay(5000);

        for (int i = 0; i <= 100; i++)
        {
            CategoryList.Add(new Category(i, $"Categoria {i}", i * 18.95M));
        }
    }
    
    public record Category(int Id, string Title, decimal Price);
    public record Books (int Id, string Title, string Author, decimal Price);
    public record Creams (int id, string Title, string Author, decimal Price);  
    public record Task (int Id, string Description, string Author, int Datetime);


   
}

//~~/ - para calcular as rotas, acresecenta-se antes po @
