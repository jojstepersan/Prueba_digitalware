using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public class InventarioService : IInventarioService
    {
        private readonly IRepositoryBase<Inventario> _repository;
        public InventarioService(IRepositoryBase<Inventario> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Inventario> GetAll()
        {
            return _repository.GetAll();
        }

        public Inventario GetByFilter(Expression<Func<Inventario, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Inventario GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Inventario, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Inventario> GetListByFilter(Expression<Func<Inventario, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Inventario entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Inventario entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Inventario entity)
        {
            _repository.Update(entity);
        }
    }
}
