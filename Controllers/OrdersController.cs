using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cSharpBurgerShack.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{

  private readonly OrdersService _ordersService;

  public OrdersController(OrdersService ordersService)
  {
    _ordersService = ordersService;
  }

  [HttpGet]
  public ActionResult<List<Order>> GetAllOrders()
  {
    try
    {
      return Ok(_ordersService.GetAllOrders());
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Order> GetOneOrder(int id)
  {
    try
    {
      Order order = _ordersService.GetOneOrder(id);
      return Ok(order);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Order> CreateOrder([FromBody] Order orderData)
  {
    try
    {
      Order order = _ordersService.CreateOrder(orderData);
      return Ok(order);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Order> SendOutOrder(int id)
  {
    try
    {
      Order order = _ordersService.SendOutOrder(id);
      return Ok(order);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<string> RemoveOrder(int id)
  {
    try
    {
      string message = _ordersService.RemoveOrder(id);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
