using System;
using InventarioData.Model;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public interface IPersonaService
    {
        IEnumerable<Persona> GetAll();
        Persona GetById(int id);
        Persona GetByFilter(Expression<Func<Persona, bool>> filter);
        List<Persona> GetListByFilter(Expression<Func<Persona, bool>> filter);
        int GetCount(Expression<Func<Persona, bool>> filter);
        void Insert(Persona entity);
        void Remove(Persona entity);
        void Update(Persona entity);
    }
}
