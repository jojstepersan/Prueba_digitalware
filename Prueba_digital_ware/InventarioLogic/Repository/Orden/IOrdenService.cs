using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface IOrdenService
    {
        IEnumerable<Orden> GetAll();
        Orden GetById(int id);
        Orden GetByFilter(Expression<Func<Orden, bool>> filter);
        List<Orden> GetListByFilter(Expression<Func<Orden, bool>> filter);
        int GetCount(Expression<Func<Orden, bool>> filter);
        void Insert(Orden entity);
        void Remove(Orden entity);
        void Update(Orden entity);
    }
}
