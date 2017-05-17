using System;
using System.Collections.Generic;
using BlackjackAttack.Models;

namespace BlackjackAttack.DataLayer
{
    public interface ITableRepository
    {
        void Add(Table item);
        IEnumerable<Table> GetAll();
        Table Find(Guid key);
        void Remove(Guid key);
        void Update(Table item);
    }
}