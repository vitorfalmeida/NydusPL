using NydusPL.BD;
using NydusPL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NydusPL.Repository
{
    public class HistoricoCargoRepository : Repository<HistoricoCargo>, IHistoricoCargoRepository
    {
        public HistoricoCargoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<HistoricoCargo> GetByColaboradorId(int colaboradorId)
        {
            return _dbSet.Where(h => h.ColaboradorId == colaboradorId).ToList();
        }

        public IEnumerable<HistoricoCargo> GetByCargoId(int cargoId)
        {
            return _dbSet.Where(h => h.CargoId == cargoId).ToList();
        }

        public IEnumerable<HistoricoCargo> GetByPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            return _dbSet.Where(h => h.DataInicio >= dataInicio && h.DataFim <= dataFim).ToList();
        }

        // Implementação dos métodos genéricos da interface IRepository<T>
        public override IEnumerable<HistoricoCargo> GetAll()
        {
            return _dbSet.ToList();
        }

        public override HistoricoCargo GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public override void Add(HistoricoCargo entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public override void Update(HistoricoCargo entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public override void Remove(HistoricoCargo entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }

}