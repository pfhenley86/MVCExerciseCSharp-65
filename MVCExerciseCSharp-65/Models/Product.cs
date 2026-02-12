namespace MVCExerciseCSharp_65.Models;

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryID { get; set; }
    public bool OnSale { get; set; }
    public int Stocklevel { get; set; }
}