using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpBurgerShack.Repositories;

public class OrdersRepository
{

  private List<Order> dbOrders = new List<Order>();

  public OrdersRepository()
  {
    dbOrders.Add(new Order(2, 1, 1, true, false, "Drench it ocky way bruv", 1));
    dbOrders.Add(new Order(2, 2, 2, true, false, "Put crispy fries on the burger under the top-bun", 2));
    dbOrders.Add(new Order(3, 2, 2, true, true, "Put Big Mac sauce on it", 3));
  }
  internal List<Order> GetAllOrders()
  {
    return dbOrders;
  }

  internal Order GetOneOrder(int id)
  {
    Order order = dbOrders.Find(order => order.Id == id);
    return order;
  }

  internal Order CreateOrder(Order orderData)
  {
    orderData.Id = dbOrders[dbOrders.Count - 1].Id + 1;
    dbOrders.Add(new Order(orderData.Buns, orderData.Patties, orderData.Cheese, orderData.Onions, orderData.Pickles, orderData.SpecialRequest, orderData.Id));
    return orderData;
  }

  internal bool RemoveCat(int id)
  {
    int count = dbOrders.RemoveAll(order => order.Id == id);
    return count > 0;
  }
}
