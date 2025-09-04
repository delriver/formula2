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
    public class FastLapRepository : Repository<FastLap>, IFastLapRepository
    {
        private readonly ApplicationDbContext _db;

        public FastLapRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(FastLap obj)
        {
            _db.FastLaps.Update(obj);
        }
    }
}
