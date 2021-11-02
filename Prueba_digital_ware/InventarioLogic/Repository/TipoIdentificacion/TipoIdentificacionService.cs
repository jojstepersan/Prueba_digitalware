using System;
using System.Collections.Generic;
using System.Text;
using InventarioData.Model;
using System.Linq.Expressions;

namespace InventarioLogic.Repository
{
    public class TipoIdentificacionService : ITipoIdentificacionService
    {

        private readonly IRepositoryBase<TipoIdentificacion> _repository;

        public TipoIdentificacionService(IRepositoryBase<TipoIdentificacion> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TipoIdentificacion> GetAll()
        {
            return _repository.GetAll();
        }

        public TipoIdentificacion GetByFilter(Expression<Func<TipoIdentificacion, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public TipoIdentificacion GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<TipoIdentificacion, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<TipoIdentificacion> GetListByFilter(Expression<Func<TipoIdentificacion, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(TipoIdentificacion entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(TipoIdentificacion entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TipoIdentificacion entity)
        {
            _repository.Update(entity);
        }
    }
}

