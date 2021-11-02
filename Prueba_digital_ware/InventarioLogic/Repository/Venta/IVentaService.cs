using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using InventarioData.Model;

namespace InventarioLogic.Repository
{
    public interface IVentaService
    {
        IEnumerable<Venta> GetAll();
        Venta GetById(int id);
        Venta GetByFilter(Expression<Func<Venta, bool>> filter);
        List<Venta> GetListByFilter(Expression<Func<Venta, bool>> filter);
        int GetCount(Expression<Func<Venta, bool>> filter);
        void Insert(Venta entity);
        void Remove(Venta entity);
        void Update(Venta entity);
    }
}
