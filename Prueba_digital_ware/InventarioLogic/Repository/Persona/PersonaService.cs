using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventarioLogic.Repository
{
    public class PersonaService: IPersonaService
    {

        private readonly IRepositoryBase<Persona> _repository;

        public PersonaService(IRepositoryBase<Persona> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Persona> GetAll()
        {
            return _repository.GetAll();
        }

        public Persona GetByFilter(Expression<Func<Persona, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Persona GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Persona, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Persona> GetListByFilter(Expression<Func<Persona, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Persona entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Persona entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Persona entity)
        {
            _repository.Update(entity);
        }
    }
}
