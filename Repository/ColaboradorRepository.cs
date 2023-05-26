using NydusPL.BD;
using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NydusPL.Repository
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Colaborador> GetByMatricula(string matricula)
        {
            return _dbSet.Where(c => c.Matricula == matricula).ToList();
        }

        public IEnumerable<Colaborador> GetByDataAdmissao(DateTime dataAdmissao)
        {
            return _dbSet.Where(c => c.DataAdmissao == dataAdmissao).ToList();
        }

        public IEnumerable<Colaborador> GetByDataDemissao(DateTime dataDemissao)
        {
            return _dbSet.Where(c => c.DataDemissao == dataDemissao).ToList();
        }

        // Implementação dos métodos genéricos da interface IRepository<T>
        public override IEnumerable<Colaborador> GetAll()
        {
            return _dbSet.ToList();
        }

        public override Colaborador GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public override void Add(Colaborador entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public override void Update(Colaborador entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public override void Remove(Colaborador entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }

}