using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public class ClienteService:IClienteService
    {

        private readonly IRepositoryBase<Cliente> _repository;

        public ClienteService(IRepositoryBase<Cliente> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _repository.GetAll();
        }

        public Cliente GetByFilter(Expression<Func<Cliente, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Cliente GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Cliente, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Cliente> GetListByFilter(Expression<Func<Cliente, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Cliente entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Cliente entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Cliente entity)
        {
            _repository.Update(entity);
        }
    }
}
