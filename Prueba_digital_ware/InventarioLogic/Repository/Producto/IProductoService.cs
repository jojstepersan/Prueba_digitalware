using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface IProductoService
    {
        IEnumerable<Producto> GetAll();
        Producto GetById(int id);
        Producto GetByFilter(Expression<Func<Producto, bool>> filter);
        List<Producto> GetListByFilter(Expression<Func<Producto, bool>> filter);
        List<Producto> GetMinimoExistencia();
        int GetCount(Expression<Func<Producto, bool>> filter);
        void Insert(Producto entity);
        void Remove(Producto entity);
        void Update(Producto entity);
    }
}
