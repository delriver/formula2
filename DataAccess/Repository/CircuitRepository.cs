using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CircuitRepository : Repository<Circuit>, ICircuitRepository
    {
        private readonly ApplicationDbContext _db;

        public CircuitRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Circuit obj)
        {
            _db.Circuits.Update(obj);
        }
    }
}
