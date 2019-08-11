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
        public void RentScooter([FromQuery] int scooterId, [FromBody] Guid userId)
        {
            _rentalService.RentScooter(userId, scooterId);
        }

        [HttpPatch("{scooterId}/rental")]
        public void ReturnScooter([FromQuery] int scooterId, [FromBody] Guid userId)
        {
            _rentalService.EndRental(userId, scooterId);
        }

        [HttpPost("{scooterId}/defect")]
        public void ReportDefect([FromQuery] int scooterId, [FromBody] DefectDtoApi defectDto)
        {
            _defectService.ReportDefect(defectDto.UserId, scooterId, defectDto.DefectDescription);
        }

        [HttpPatch("{scooterId}/defect")]
        public void DefectResolved([FromQuery] int scooterId)
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