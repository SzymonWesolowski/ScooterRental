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

        [HttpGet]
        public ActionResult<User> TopTenUsers([FromServices] IStatsService statsService)
        {
            return Ok(statsService.GetTopTenUsers());
        }
    }
}