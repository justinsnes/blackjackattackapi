using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using BlackjackAttack.Models;

namespace BlackjackAttack.DataLayer
{
    public class TableRepository : ITableRepository
    {
        private readonly BlackjackAttackContext _context;

        public TableRepository(BlackjackAttackContext context)
        {
            _context = context;
        }

        public IEnumerable<Table> GetAll()
        {
            return _context.Tables.ToList();
        }

        public void Add(Table item)
        {
            _context.Tables.Add(item);
            _context.SaveChanges();
        }

        public Table Find(Guid key)
        {
            return _context.Tables.Include(x => x.CurrentShoe.Cards).FirstOrDefault(t => t.Key == key);
        }

        public void Remove(Guid key)
        {
            var entity = _context.Tables.First(t => t.Key == key);
            _context.Tables.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Table item)
        {
            _context.Tables.Update(item);
            _context.SaveChanges();
        }
    }
}