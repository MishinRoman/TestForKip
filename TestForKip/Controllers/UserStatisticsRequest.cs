namespace TestForKip.Controllers
{
    public class UserStatisticsRequest
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public TimeSpan TimeSpan { get; set; }

    }
}