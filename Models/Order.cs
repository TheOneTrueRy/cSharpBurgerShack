using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpBurgerShack.Models
{
  public class Order
  {
    public Order(int buns, int patties, int cheese, bool onions, bool pickles, string specialRequest, int id)
    {
      Id = id;
      Buns = buns;
      Patties = patties;
      Cheese = cheese;
      Onions = onions;
      Pickles = pickles;
      SpecialRequest = specialRequest;
    }

    public int Id { get; set; }
    public int Buns { get; set; }
    public int Patties { get; set; }
    public int Cheese { get; set; }
    public bool Onions { get; set; }
    public bool Pickles { get; set; }
    public string SpecialRequest { get; set; }
    public bool Sold { get; private set; } = false;

    public void SendOutOrder()
    {
      this.Sold = true;
    }
  }

}