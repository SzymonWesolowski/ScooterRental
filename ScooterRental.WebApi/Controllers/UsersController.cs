using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScooterRental.Application;
using ScooterRental.Domain;
using ScooterRental.WebApi.Dtos;

namespace ScooterRental.WebApi.Controllers
{
    [Route("api/users/top10")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<UserDtoApi>> TopTenUsers([FromServices] IStatsService statsService)
        {
            var users = statsService.GetTopTenUsers();
            var usersDto = new  List<UserDtoApi>();
            foreach (var user in users)
            {
                usersDto.Add(ModelToDto(user)); 
            }
            return Ok(usersDto);
        }

        private UserDtoApi ModelToDto(User user)
        {
            return new UserDtoApi()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}