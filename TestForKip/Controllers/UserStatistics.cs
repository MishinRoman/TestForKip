using System.ComponentModel.DataAnnotations;

namespace TestForKip.Controllers
{
    public class UserStatistics
    {
        [Key]
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }=DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
