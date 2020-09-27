using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskPlannerApi.Repositories;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ISprocRepository _repository;

        public ReportsController(ISprocRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("Progress")]
        public Task<IList<ProgressReportEntity>> GetProgressReport([FromQuery] int? teamId, [FromQuery] int? userId) 
        {
            (teamId, userId) = (teamId != 0 ? teamId : null, userId != 0 ? userId : null);
            return _repository
            .GetStoredProcedure("[dbo].[Sp_ProgressReport]")
            .WithSqlParams(
                (nameof(teamId), teamId), 
                (nameof(userId), userId))
            .ExecuteStoredProcedureAsync<ProgressReportEntity>();
        }
    }
}
