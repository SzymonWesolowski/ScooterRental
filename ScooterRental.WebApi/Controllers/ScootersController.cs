using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ScooterRental.Application;
using ScooterRental.WebApi.Dtos;

namespace ScooterRental.WebApi.Controllers
{
    [Route("api/Scooters")]
    [ApiController]
    public class ScootersController : ControllerBase
    {
        private readonly IDefectService _defectService;
        private readonly IRentalService _rentalService;
        private readonly IStatsService _statsService;

        public ScootersController(IDefectService defectService, IRentalService rentalService,
            IStatsService statsService)
        {
            _defectService = defectService;
            _rentalService = rentalService;
            _statsService = statsService;
        }

        [HttpPost("{scooterId}/rental")]
        public ActionResult RentScooter([FromRoute] int scooterId, [FromBody] Guid userId)
        {
                _rentalService.RentScooter(userId, scooterId);
                return Ok();
        }

        [HttpPatch("{scooterId}/rental")]
        public ActionResult ReturnScooter([FromRoute] int scooterId, [FromBody] Guid userId)
        {
            _rentalService.EndRental(userId, scooterId);
            return Ok();
        }

        [HttpPost("{scooterId}/defect")]
        public void ReportDefect([FromRoute] int scooterId, [FromBody] DefectDtoApi defectDto)
        {
            _defectService.ReportDefect(defectDto.UserId, scooterId, defectDto.DefectDescription);
        }

        [HttpPatch("{scooterId}/defect")]
        public void DefectResolved([FromRoute] int scooterId)
        {
            _defectService.DefectResolved(scooterId);
        }

        [HttpGet("status")]
        public ActionResult<string> GetNumberOfAvailableScooters()
        {
            string available = _statsService.GetNumberOfAvailableScooters().ToString();
            return Ok(available);
        }

        [HttpGet("status/usageTime")]
        public ActionResult<List<(ScooterDtoApi, TimeSpan)>> GetUsageTime()
        {
            return Ok(_statsService.GetUsageTime());
        }
    }
}