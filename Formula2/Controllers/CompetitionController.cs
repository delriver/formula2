using System.Diagnostics;
using DataAccess.Data;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Formula2.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly IUnitOfWork _db;

        public CompetitionController(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert()
        {
            return View();
        }
    }
}
