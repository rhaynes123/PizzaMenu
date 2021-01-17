using System;
using System.Collections.Generic;
using PizzaMenu.Models;

namespace PizzaMenu.Repositories
{
    public interface IMenuItemRepository
    {
        public List<MenuItem> GetItems();
        public MenuItem GetItemById(int Id);
        public int ItemWaitTime(int Id);
    }
}
