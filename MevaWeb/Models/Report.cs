namespace MevaWeb.Controllers
{
    public class Report
    {
        public int Id { get; set; }
        public bool Read { get; set; } = false;
        public string Reason { get; set; }
        public bool Marked { get; set; }
        public int AccountId { get; set; }

    }
}