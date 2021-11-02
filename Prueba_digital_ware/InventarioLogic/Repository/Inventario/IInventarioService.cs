using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface IInventarioService
    {
        IEnumerable<Inventario> GetAll();
        Inventario GetById(int id);
        Inventario GetByFilter(Expression<Func<Inventario, bool>> filter);
        List<Inventario> GetListByFilter(Expression<Func<Inventario, bool>> filter);
        int GetCount(Expression<Func<Inventario, bool>> filter);
        void Insert(Inventario entity);
        void Remove(Inventario entity);
        void Update(Inventario entity);
    }
}
