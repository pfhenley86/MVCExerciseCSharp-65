using Microsoft.AspNetCore.Mvc;
using MVCExerciseCSharp_65.Data;

namespace MVCExerciseCSharp_65.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }
    
    // GET
    public IActionResult Index()
    {
        var products = _repository.GetAllProducts();
        return View(products);
    }
}