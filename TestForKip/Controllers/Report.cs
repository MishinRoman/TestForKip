namespace TestForKip.Controllers
{
    public class Report
    {
        public Guid Id { get; set; }
        public int Precent { get; set; }
        public UserStatisticsRequest? Statistics { get; set; }

    }
}