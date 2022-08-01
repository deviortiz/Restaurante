using Pedidos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IMenuService
    {
        public List<Menu> List();
    }
}
