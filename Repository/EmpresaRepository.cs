using NydusPL.BD;
using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NydusPL.Repository
{
    public class EmpresaRepository : Repository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public Empresa GetByCnpj(string cnpj)
        {
            return _dbSet.FirstOrDefault(e => e.Cnpj == cnpj);
        }
        // Implemente outros métodos específicos da entidade Empresa, se necessário

        // Implementação dos métodos genéricos da interface IRepository<T>
        public override IEnumerable<Empresa> GetAll()
        {
            return _dbSet.ToList();
        }

        public override Empresa GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public override void Add(Empresa entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public override void Update(Empresa entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public override void Remove(Empresa entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
