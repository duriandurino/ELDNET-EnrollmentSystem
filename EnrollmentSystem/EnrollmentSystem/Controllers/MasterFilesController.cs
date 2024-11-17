using EnrollmentSystem.Data;
using EnrollmentSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Controllers
{
    public class MasterFilesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public MasterFilesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
