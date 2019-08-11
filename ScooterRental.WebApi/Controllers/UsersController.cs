using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScooterRental.Application;
using ScooterRental.Domain;

namespace ScooterRental.WebApi.Controllers
{
    [Route("api/users/top10")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public UsersController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet]
        public ActionResult<User> TopTenUsers()
        {
            return Ok(_statsService.GetTopTenUsers());
        }
    }
}