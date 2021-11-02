
using InventarioData.Model;
using InventarioLogic.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public class OrdenService : IOrdenService
    {
        private readonly IRepositoryBase<Orden> _repository;
        public OrdenService(IRepositoryBase<Orden> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Orden> GetAll()
        {
            return _repository.GetAll();
        }

        public Orden GetByFilter(Expression<Func<Orden, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Orden GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Orden, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Orden> GetListByFilter(Expression<Func<Orden, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Orden entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Orden entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Orden entity)
        {
            _repository.Update(entity);
        }
 
    }
}
