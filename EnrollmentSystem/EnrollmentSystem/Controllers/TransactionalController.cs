using EnrollmentSystem.Data;
using EnrollmentSystem.Models.Dto;
using EnrollmentSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Controllers
{
    public class TransactionalController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public TransactionalController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
