using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface ITipoIdentificacionService
    {
        IEnumerable<TipoIdentificacion> GetAll();
        TipoIdentificacion GetById(int id);
        TipoIdentificacion GetByFilter(Expression<Func<TipoIdentificacion, bool>> filter);
        List<TipoIdentificacion> GetListByFilter(Expression<Func<TipoIdentificacion, bool>> filter);
        int GetCount(Expression<Func<TipoIdentificacion, bool>> filter);
        void Insert(TipoIdentificacion entity);
        void Remove(TipoIdentificacion entity);
        void Update(TipoIdentificacion entity);
    }
}
