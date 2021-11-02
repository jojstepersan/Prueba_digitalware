using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using InventarioData.Model;

namespace InventarioLogic.Repository
{
    public class VentaService : IVentaService
    {

        private readonly IRepositoryBase<Venta> _repository;

        public VentaService(IRepositoryBase<Venta> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Venta> GetAll()
        {
            return _repository.GetAll();
        }

        public Venta GetByFilter(Expression<Func<Venta, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Venta GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Venta, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Venta> GetListByFilter(Expression<Func<Venta, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Venta entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Venta entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Venta entity)
        {
            _repository.Update(entity);
        }
    }
}
