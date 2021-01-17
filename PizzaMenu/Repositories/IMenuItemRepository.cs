using System;
using System.Collections.Generic;
using PizzaMenu.Models;

namespace PizzaMenu.Repositories
{
    public interface IMenuItemRepository
    {
        public List<MenuItem> GetItems();
    }
}
