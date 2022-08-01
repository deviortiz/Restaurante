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
    public class MeseraService : IMeseraService
    {
        private readonly IMeseraRepository repo;

        public MeseraService(IMeseraRepository _repo)
        {
            repo = _repo;
        }
        public List<Mesera> List()
        {
            return repo.List();
        }
    }
}
