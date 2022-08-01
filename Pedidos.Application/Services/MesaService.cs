using Pedidos.Application.Interfaces;
using Pedidos.Domain.Interfaces;
using Pedidos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepository repo;

        public MesaService(IMesaRepository _repo)
        {
            repo = _repo;
        }
        public List<Mesa> List()
        {
            return repo.List();
        }
    }
}
