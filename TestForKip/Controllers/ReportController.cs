using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TestForKip.Controllers
{
    public class ReportController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IConfiguration _configuration;
       


        public ReportController(MyDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }




        [HttpPost("report/user-statistics")]
        public async Task<Guid> GetUserStatisticsAsync([FromBody] UserStatistics statistics)
        {
            

            var newRequest = new UserStatisticsRequest() { Id = Guid.NewGuid(), UserId = statistics.UserId, TimeSpan = (statistics.EndDate - statistics.StartDate) };

            _context.requests.Add(newRequest);

            _context.SaveChanges();

            return newRequest.Id;
        }
        [HttpGet("report/user-statistics")]
        public async Task<Report> GetStatisticsAsync(Guid id)
        {
            var request = await _context.requests.FirstOrDefaultAsync(i => i.Id == id);
            var response = await _context.UserStatistics.FirstOrDefaultAsync(i=>i.UserId==request.UserId);

            var report = new Report { Id = Guid.NewGuid(), Statistics = request, Precent=(int)(request.TimeSpan.TotalMilliseconds/DateTime.Now.Millisecond)*100 };
            await  _context.Reports.AddAsync(report);

            return report;
           
        }

    }
}
