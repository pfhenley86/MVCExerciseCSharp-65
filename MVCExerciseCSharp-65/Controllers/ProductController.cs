using Microsoft.AspNetCore.Mvc;
using MVCExerciseCSharp_65.Data;
using MVCExerciseCSharp_65.Models;

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
    
    // VIEW
    public IActionResult ViewProduct(int id)
    {
        var product = _repository.GetProduct(id);
        return View(product);
    }
    
    // UPDATE VIEW
    public IActionResult UpdateProduct(int id)
    {
        var product = _repository.GetProduct(id);
        if(product == null)
        {
            return View("ProductNotFound");
        }
        return View(product);
    }
    
    // UPDATE POST
    public IActionResult UpdateProductToDatabase(Product product)
    {
        _repository.UpdateProduct(product);
        
        return RedirectToAction("ViewProduct", new { id = product.ProductID });
    }
    
    // CREATE VIEW
    public IActionResult InsertProduct()
    {
        var product = _repository.AssignCategory();
        return View(product);
    }
    
    // CREATE PRODUCT
    public IActionResult InsertProductToDatabase(Product productToInsert)
    {
        _repository.InsertProduct(productToInsert);
        return RedirectToAction("Index");
    }
    
    // DELETE PRODUCT
    public IActionResult DeleteProduct(Product product)
    {
        _repository.DeleteProduct(product);
        return RedirectToAction("Index");
    }
    
}