using Pedidos.Application.Interfaces;
using Pedidos.Domain.Interfaces;
using Pedidos.Domain.Models;
using System;

namespace Pedidos.Application.Services
{
    public class MenuDiaService : IMenuDiaService
    {
        private readonly IMenuDiaRepository repo;

        public MenuDiaService(IMenuDiaRepository _repo)
        {
            repo = _repo;
        }
        public List<MenuDia> List()
        {
            return repo.List();
        }
    }
}
