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
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        private readonly ApplicationDbContext _db;

        public DriverRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Driver obj)
        {
            _db.Drivers.Update(obj);
        }
    }
}
