using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Models;
using Newtonsoft.Json;

namespace Formula2.Controllers
{
    public class DriverController : Controller
    {
        private readonly IUnitOfWork _db;

        public DriverController(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        #region View Calls

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert()
        {
            return View();
        }

        #endregion


        #region APICalls

        [HttpPost]
        public async Task<IActionResult> CreateDriver([FromForm] string driver)
        {
            using var transaction = _db.GetContext().Database.BeginTransaction();
            try
            {
                if (!string.IsNullOrEmpty(driver))
                {
                    var driverObj = JsonConvert.DeserializeObject<Driver>(driver);

                    //Add creator indentity
                    _db.Driver.Add(driverObj);
                    _db.Save();

                    int driverId = driverObj.Id;
                }
                else
                {
                    throw new Exception("Información no capturada correctamente");
                }

                transaction.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Driver> objDriversList = _db.Driver.GetAll(null).ToList();
            return Json(new { data = objDriversList });
        }

        #endregion
    }
}
