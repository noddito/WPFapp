using ConsoleApp1.Models;

namespace ConsoleApp1.Services.Interfaces
{
    public interface IProductService
    {
         ProductModel CreateProduct(string name, decimal price);
         ProductModel[] GetProducts();
         ProductModel ChangePrice(int id, decimal price);
    }
}
