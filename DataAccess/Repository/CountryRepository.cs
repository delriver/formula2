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
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private readonly ApplicationDbContext _db;

        public CountryRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Country obj)
        {
            _db.Countries.Update(obj);
        }
    }
}
