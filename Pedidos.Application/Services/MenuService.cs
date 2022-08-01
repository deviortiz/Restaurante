using Pedidos.Application.Interfaces;
using Pedidos.Domain.Interfaces;
using Pedidos.Domain.Models;
using System;

namespace Pedidos.Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository repo;

        public MenuService(IMenuRepository _repo)
        {
            repo = _repo;
        }
        public List<Menu> List()
        {
            return repo.List();
        }
    }
}
