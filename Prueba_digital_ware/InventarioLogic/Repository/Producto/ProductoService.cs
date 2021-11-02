using InventarioData.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using System.Linq;


namespace InventarioLogic.Repository
{
    public class ProductoService : IProductoService
    {

        private readonly IRepositoryBase<Producto> _repository;

        public ProductoService(IRepositoryBase<Producto> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Producto> GetAll()
        {
            return _repository.GetAll();
        }

        public Producto GetByFilter(Expression<Func<Producto, bool>> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public Producto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public int GetCount(Expression<Func<Producto, bool>> filter)
        {
            return _repository.GetCount(filter);
        }

        public List<Producto> GetListByFilter(Expression<Func<Producto, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void Insert(Producto entity)
        {
            _repository.Insert(entity);
        }

        public void Remove(Producto entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Producto entity)
        {
            _repository.Update(entity);
        }
        public List<Producto> GetMinimoExistencia()
        {
            using (InventarioData.InventarioDataContext context = new InventarioData.InventarioDataContext())
            {
                return (from inv in context.Inventarios
                        join pro in context.Productos on inv.ProductoId equals pro.ProductoId
                        where inv.CantidadExistente == 5
                        select pro).ToList();

            }
        }
    }
}
