using NydusPL.BD;
using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NydusPL.Repository
{
    public class CargoRepository : Repository<Cargo>, ICargoRepository
    {
        public CargoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Cargo> GetByNome(string nome)
        {
            return _dbSet.Where(c => c.Nome == nome).ToList();
        }

        public IEnumerable<Cargo> GetByCBO(string cbo)
        {
            return _dbSet.Where(c => c.CBO == cbo).ToList();
        }

        // Implemente outros métodos específicos da entidade Cargo, se necessário

        // Implementação dos métodos genéricos da interface IRepository<T>
        public override IEnumerable<Cargo> GetAll()
        {
            return _dbSet.ToList();
        }

        public override Cargo GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public override void Add(Cargo entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public override void Update(Cargo entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public override void Remove(Cargo entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
