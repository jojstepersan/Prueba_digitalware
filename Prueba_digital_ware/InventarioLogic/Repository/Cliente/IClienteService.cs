using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        Cliente GetByFilter(Expression<Func<Cliente, bool>> filter);
        List<Cliente> GetListByFilter(Expression<Func<Cliente, bool>> filter);
        int GetCount(Expression<Func<Cliente, bool>> filter);
        void Insert(Cliente entity);
        void Remove(Cliente entity);
        void Update(Cliente entity);
    }
}
