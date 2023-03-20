using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpBurgerShack.Services;

public class OrdersService
{
  private readonly OrdersRepository _repo;

  public OrdersService(OrdersRepository repo)
  {
    _repo = repo;
  }

  public List<Order> GetAllOrders()
  {
    return _repo.GetAllOrders();
  }

  internal Order GetOneOrder(int id)
  {
    Order order = _repo.GetOneOrder(id);
    if (order == null) throw new Exception("No Order With That ID");
    return order;
  }

  internal Order CreateOrder(Order orderData)
  {
    Order order = _repo.CreateOrder(orderData);
    return order;
  }

  internal Order SendOutOrder(int id)
  {
    Order order = this.GetOneOrder(id);
    order.SendOutOrder();
    return order;
  }

  internal string RemoveOrder(int id)
  {
    Order order = this.GetOneOrder(id);
    bool result = _repo.RemoveCat(id);
    if (!result) throw new Exception("No Order With That ID!");
    return $"Order number {order.Id} was removed from the system.";

  }
}
