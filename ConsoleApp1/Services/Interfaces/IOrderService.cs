using ConsoleApp1.Enums;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services.Interfaces
{
    public interface IOrderService
    {
         OrderModel GetOrder(int id);
         OrderModel[] GetOrders();
         OrderModel AddOrder(ProductOrderModel[] products,string description, string address);
         OrderModel ChangeStatus(int id, EStatus status);
    }
}