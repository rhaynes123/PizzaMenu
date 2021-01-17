using System;
using System.Linq;
using System.Collections.Generic;
using PizzaMenu.Data;
using PizzaMenu.Models;

namespace PizzaMenu.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly ApplicationDbContext _context;
        public MenuItemRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public List<MenuItem> GetItems()
        {
            return _context.MenuItems.Where(p =>p.Active == true).ToList();
        }
    }
}
